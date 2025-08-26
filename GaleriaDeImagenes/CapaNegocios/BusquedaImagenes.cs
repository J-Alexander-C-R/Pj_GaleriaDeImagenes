using GaleriaDeImagenes.Servicios_FrmGaleria;
using System.Drawing;
using System.Net.Http;

namespace GaleriaDeImagenes.ServiciosExternos_FrmGaleria
{
    public class BusquedaImagenes
    {
        // TODO: Guarda el último texto de búsqueda realizado
        public string UltimaBusqueda { get; private set; } = "";

        // TODO: Número de página actual en la búsqueda
        public int PaginaActual { get; private set; } = 1;

        // TODO: Número de fotos que se mostrarán por página
        public int FotosPorPagina { get; set; } = 5;

        // TODO: Referencia a la clase que maneja la API de Pexels
        private readonly Pexels_Api api;

        // TODO: Constructor que recibe la instancia de la API
        public BusquedaImagenes(Pexels_Api apiClient)
        {
            api = apiClient;
        }

        // TODO: Inicia una nueva búsqueda guardando el término y reseteando la página
        public void NuevaBusqueda(string query)
        {
            UltimaBusqueda = query;
            PaginaActual = 1;
        }

        // TODO: Avanza a la siguiente página de resultados
        public void CargarMas() => PaginaActual++;

        // TODO: Retrocede una página si no está en la primera
        public void RetrocederPagina() { if (PaginaActual > 1) PaginaActual--; }

        // TODO: Método principal para obtener imágenes de la API
        // TODO: CancellationToken para permitir cancelación desde el formulario
        public async Task<List<Image>> ObtenerImagenesAsync(CancellationToken token = default)
        {
            // TODO: Validar que se haya hecho una búsqueda antes
            if (string.IsNullOrEmpty(UltimaBusqueda))
                throw new InvalidOperationException("Debe realizarse una búsqueda primero.");

            // TODO: Llamar a la API pasando el término, cantidad por página, número de página y el token
            var resultado = await api.GetImagesAsync(UltimaBusqueda, FotosPorPagina, PaginaActual, token);

            // TODO: Si la API no devuelve fotos, retornar una lista vacía
            if (resultado?.Photos == null || resultado.Photos.Count == 0)
                return new List<Image>();

            // TODO: Usamos HttpClient para descargar las imágenes desde las URLs que devuelve la API
            using (HttpClient client = new HttpClient())
            {
                // TODO: Creamos una colección de tareas en paralelo para descargar varias imágenes a la vez
                var tasks = resultado.Photos
                    .Take(FotosPorPagina) // TODO: Tomamos solo la cantidad configurada por página
                    .Select(async p =>
                    {
                        // TODO: Descargamos el stream de la imagen con soporte de cancelación
                        var stream = await client.GetStreamAsync(p.Src.Medium, token);

                        // TODO: Convertimos el stream en una imagen de .NET
                        return Image.FromStream(stream);
                    });

                // TODO: Ejecutamos todas las descargas en paralelo y devolvemos la lista de imágenes
                return (await Task.WhenAll(tasks)).ToList();
            }
        }
    }
}

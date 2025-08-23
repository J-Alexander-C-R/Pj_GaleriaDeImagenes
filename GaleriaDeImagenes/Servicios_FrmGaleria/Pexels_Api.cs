using GaleriaDeImagenes.Modelos_FrmGaleria;
using Newtonsoft.Json;

namespace GaleriaDeImagenes.Servicios_FrmGaleria
{
    public class Pexels_Api
    {
        // TODO: Instancia de HttpClient
        private readonly HttpClient _client;
        private readonly string _apiKey = "m54umtyfduRUnq0BTgqXYkDsi5dDKLgwdZIl1MoEOEA0ghBxtjKSJ5fu";

        public Pexels_Api()
        {
            // TODO: Inicializamos el cliente HTTP solo una vez
            _client = new HttpClient();

            // TODO: Pexels requiere que pongamos la API KEY en la cabecera de autorización
            _client.DefaultRequestHeaders.Add("Authorization", _apiKey);
        }

        //
        public async Task<Pexels_Respuesta> GetImagesAsync(string query, int cantidad, int page = 1, CancellationToken token = default)
        {
            // TODO: Construimos la URL con el texto de búsqueda, cantidad y página
            string url = $"https://api.pexels.com/v1/search?query={Uri.EscapeDataString(query)}&per_page={cantidad}&page={page}";

            // TODO: Hacemos la llamada con token de cancelación
            var response = await _client.GetAsync(url, token);

            response.EnsureSuccessStatusCode();

            // TODO: Leer contenido de la respuesta como cadena JSON
            string json = await response.Content.ReadAsStringAsync(token);

            // TODO: Convertimos el JSON en un objeto C#
            return JsonConvert.DeserializeObject<Pexels_Respuesta>(json) ?? new Pexels_Respuesta();
        }
    }
}

using GaleriaDeImagenes.Servicios_FrmGaleria;
using GaleriaDeImagenes.ServiciosExternos_FrmGaleria;

namespace GaleriaDeImagenes.Forms
{
    public partial class FrmGaleria : Form
    {
        // TODO: Fuente de cancelación para búsquedas asíncronas
        private CancellationTokenSource cts;

        // TODO: Bandera que indica si hay una búsqueda en curso
        private bool busquedaEnCurso = false;

        // TODO: Instancia de la API de Pexels (servicio externo para obtener imágenes)
        private readonly Pexels_Api api = new Pexels_Api();

        // TODO: Clase auxiliar encargada de gestionar búsquedas y paginación
        private readonly BusquedaImagenes buscador;

        // TODO: Guarda el último término de búsqueda (para navegar entre páginas)
        private string ultimoQuery = "";

        // TODO: Arreglo de PictureBox donde se mostrarán las imágenes
        private PictureBox[] pictureBoxes;

        // TODO: Evento personalizado. notifica cuando se descargaron imágenes
        public event EventHandler<List<Image>>? ImagenesDescargadas;

        public FrmGaleria()
        {
            InitializeComponent(); // TODO: Inicializa los componentes del formulario

            buscador = new BusquedaImagenes(api); // TODO: Crear buscador con la API de Pexels

            // TODO: Inicializar el arreglo con los PictureBox ya colocados en el formulario
            pictureBoxes = new PictureBox[]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: Obtener el texto de búsqueda desde el TextBox
            string query = txtBuscar.Text.Trim();

            // TODO: Validar que no esté vacío
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor, escribe un término de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Si ya hay una búsqueda en curso, cancelar antes de iniciar otra
            if (busquedaEnCurso && cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }

            // TODO: Crear un nuevo token de cancelación
            cts = new CancellationTokenSource();
            busquedaEnCurso = true;
            ultimoQuery = query;

            // TODO: Indicar al buscador que se inicia una nueva búsqueda
            buscador.NuevaBusqueda(query);

            try
            {
                // TODO: Llamar al método que carga y muestra imágenes
                await CargarYMostrarImagenesAsync(cts.Token);
            }
            finally
            {
                // TODO: Resetear bandera cuando termine
                busquedaEnCurso = false;
            }
        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            // TODO: Validar si ya se realizó alguna búsqueda
            if (string.IsNullOrEmpty(ultimoQuery))
            {
                MessageBox.Show("Primero realiza una búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TODO: Avanzar una página en el buscador
            buscador.CargarMas();

            // TODO: Cargar imágenes de la nueva página
            await CargarYMostrarImagenesAsync(cts?.Token ?? CancellationToken.None);
        }

        private async void btnAnterior_Click(object sender, EventArgs e)
        {
            // TODO: Validar si ya hay búsqueda realizada
            if (string.IsNullOrEmpty(ultimoQuery))
            {
                MessageBox.Show("Primero realiza una búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Verificar si ya estamos en la primera página
            if (buscador.PaginaActual <= 1)
            {
                MessageBox.Show("Ya estás en la primera página.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TODO: Retroceder una página en el buscador
            buscador.RetrocederPagina();

            // TODO: Cargar imágenes de la página anterior
            await CargarYMostrarImagenesAsync(cts?.Token ?? CancellationToken.None);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // TODO: Si hay búsqueda en curso, cancelar
            if (busquedaEnCurso && cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
                txtBuscar.Clear(); // TODO: Limpiar el campo de búsqueda
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // TODO: Cierra el formulario actual
            this.Close();
        }

        //-----------------------------Metodos---------------------------------

        // TODO: Método asíncrono que obtiene imágenes desde la API y las muestra en el formulario
        private async Task CargarYMostrarImagenesAsync(CancellationToken token)
        {
            try
            {
                // TODO: Obtener lista de imágenes desde el buscador
                var imagenes = await buscador.ObtenerImagenesAsync(token);

                // TODO: Liberar recursos previos en los PictureBox
                foreach (var pb in pictureBoxes)
                {
                    pb.Image?.Dispose();
                    pb.Image = null;
                }

                // TODO: Validar que haya imágenes
                if (imagenes != null && imagenes.Any())
                {
                    // TODO: Mostrar imágenes descargadas en los PictureBox
                    MostrarImagenes.CargarImagenes(imagenes, pictureBoxes);

                    // TODO: Lanzar evento → notificar a suscriptores que se descargaron imágenes
                    ImagenesDescargadas?.Invoke(this, imagenes);
                }
                else
                {
                    MessageBox.Show("No se encontraron imágenes para esta búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (TaskCanceledException)
            {
                // TODO: Manejar cancelación de búsqueda
                if (busquedaEnCurso)
                {
                    MessageBox.Show("Búsqueda cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException httpEx)
            {
                // TODO: Manejar errores de conexión
                MessageBox.Show($"Error de conexión: {httpEx.Message}", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // TODO: Manejar errores inesperados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

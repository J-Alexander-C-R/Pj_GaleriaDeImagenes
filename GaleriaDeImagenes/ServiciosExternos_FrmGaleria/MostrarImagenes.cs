namespace GaleriaDeImagenes.ServiciosExternos_FrmGaleria
{
    public class MostrarImagenes
    {
        // TODO: Carga imágenes en un arreglo fijo de PictureBox.
        // TODO: Ajusta cada imagen para que llene el PictureBox sin perder proporción.
        public static void CargarImagenes(List<Image> imagenes, PictureBox[] pictureBoxes)
        {
            // TODO: Recorremos imágenes hasta la cantidad mínima entre la lista y el array de PictureBox
            for (int i = 0; i < Math.Min(imagenes.Count, pictureBoxes.Length); i++)
            {
                // TODO: Ajusta la imagen al tamaño del PictureBox usando el método auxiliar
                pictureBoxes[i].Image = MetodosAuxiliares.ResizeImageToFill(
                    imagenes[i],
                    pictureBoxes[i].Size
                );
            }
        }

        // TODO: Carga imágenes dinámicamente dentro de un FlowLayoutPanel.
        // TODO: Crea nuevos PictureBox en tiempo de ejecución para cada imagen.
        public static void CargarEnFlowLayout(List<Image> imagenes, FlowLayoutPanel panel, Size tamañoImagen)
        {
            panel.Controls.Clear(); // TODO: Limpia los controles previos para evitar duplicados

            foreach (var img in imagenes)
            {
                // TODO: Crear un nuevo PictureBox configurado con propiedades visuales
                PictureBox pb = new PictureBox
                {
                    Size = tamañoImagen, // TODO: Asignar tamaño definido
                    SizeMode = PictureBoxSizeMode.Zoom, // TODO: Mantiene proporción dentro del PictureBox
                    Margin = new Padding(5), // TODO: Espaciado entre imágenes
                    Image = MetodosAuxiliares.ResizeImageToFill(img, tamañoImagen), // TODO: Ajusta la imagen al tamaño del contenedor
                    Cursor = Cursors.Hand // TODO: Cambia el cursor indicando interactividad
                };

                // TODO: Agregar evento Click que muestra la imagen en grande en una ventana emergente
                pb.Click += (s, e) =>
                {
                    // TODO: Crear formulario para la vista previa
                    Form visor = new Form
                    {
                        Text = "Vista previa",
                        Size = new Size(800, 600), // TODO: Tamaño por defecto de la ventana
                        StartPosition = FormStartPosition.CenterScreen // TODO: Centrar en pantalla
                    };

                    // TODO: PictureBox de tamaño completo dentro del formulario
                    PictureBox pbGrande = new PictureBox
                    {
                        Dock = DockStyle.Fill, // TODO: Ocupa todo el formulario
                        Image = img, // TODO: Mostrar la imagen original en su tamaño proporcional
                        SizeMode = PictureBoxSizeMode.Zoom // TODO: Ajusta al formulario manteniendo proporción
                    };

                    // TODO: Agregar el PictureBox al formulario y mostrarlo
                    visor.Controls.Add(pbGrande);
                    visor.ShowDialog();
                };

                // TODO: Agregar el PictureBox al FlowLayoutPanel
                panel.Controls.Add(pb);
            }
        }
    }
}

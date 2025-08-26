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

       
        }
    }


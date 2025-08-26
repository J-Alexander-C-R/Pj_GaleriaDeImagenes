namespace GaleriaDeImagenes.ServiciosExternos_FrmGaleria
{
    public class MetodosAuxiliares
    {
        // TODO: Método auxiliar para redimensionar una imagen y hacer que llene el área de destino
        public static Image ResizeImageToFill(Image img, Size targetSize)
        {
            // TODO: Crear un nuevo bitmap con el tamaño objetivo
            var bmp = new Bitmap(targetSize.Width, targetSize.Height);

            // TODO: Dibujar sobre el bitmap con calidad alta
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // TODO: Configurar modos de renderizado para mejor calidad
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // TODO: Calcular proporciones de escalado para ancho y alto
                float ratioX = (float)targetSize.Width / img.Width;
                float ratioY = (float)targetSize.Height / img.Height;

                // TODO: Usar el mayor ratio para asegurar que la imagen llene (aunque se recorte)
                float ratio = Math.Max(ratioX, ratioY);

                // TODO: Calcular nuevo tamaño de la imagen escalada
                int newWidth = (int)(img.Width * ratio);
                int newHeight = (int)(img.Height * ratio);

                // TODO: Calcular posición de la imagen centrada en el lienzo
                int posX = (targetSize.Width - newWidth) / 2;
                int posY = (targetSize.Height - newHeight) / 2;

                // TODO: Dibujar la imagen escalada en el nuevo bitmap
                g.DrawImage(img, posX, posY, newWidth, newHeight);
            }

            // TODO: Retornar el bitmap redimensionado
            return bmp;
        }
    }
}

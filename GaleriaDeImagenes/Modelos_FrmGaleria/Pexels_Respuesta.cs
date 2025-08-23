using Newtonsoft.Json;

namespace GaleriaDeImagenes.Modelos_FrmGaleria
{
    // TODO: Esta clase representa la respuesta completa de la API de Pexels
    public class Pexels_Respuesta
    {
        // TODO: Lista de fotos devueltas por la búsqueda
        [JsonProperty("photos")]
        public List<Pexels_Images> Photos { get; set; }
    }
}

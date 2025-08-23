

using Newtonsoft.Json;

namespace GaleriaDeImagenes.Modelos_FrmGaleria
{
    public class Pexels_Src
    {
        [JsonProperty("medium")]
        public string Medium { get; set; }

        // TODO: Imagen original de alta resolución 
        [JsonProperty("original")]
        public string Original { get; set; }
        
    }
}

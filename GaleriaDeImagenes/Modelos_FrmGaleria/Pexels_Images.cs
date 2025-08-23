using Newtonsoft.Json;

namespace GaleriaDeImagenes.Modelos_FrmGaleria
{
    public class Pexels_Images
    {
        // TODO: ID único de la imagen
        [JsonProperty("id")]
        public int Id { get; set; }

        // TODO: Contiene las URLs de diferentes tamaños de la misma imagen
        [JsonProperty("src")]
        public Pexels_Src Src { get; set; }

        // TODO: Texto alternativo de la imagen (opcional)
        [JsonProperty("alt")]
        public string Alt { get; set; }
    }
}

using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class TypeElement
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }
}


using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public class Stat
    {
        [JsonProperty("base_stat")]
        public int Base { get; set; }

        [JsonProperty("effort")]
        public long Effort { get; set; }

        [JsonProperty("stat")]
        public Species StatStat { get; set; }
    }
}


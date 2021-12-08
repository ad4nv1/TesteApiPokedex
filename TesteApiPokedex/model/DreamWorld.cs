using System;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class DreamWorld
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }
    }
}


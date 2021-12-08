using System;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }
    }
}


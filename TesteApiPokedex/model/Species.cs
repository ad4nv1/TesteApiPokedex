using System;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}


using System;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public class Species
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        


    }
}


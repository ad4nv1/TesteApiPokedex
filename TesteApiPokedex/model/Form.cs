using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class Form
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        // tentativas

        //[JsonProperty("type")]
        //public Pokemon Types { get; set; }

        //[JsonProperty("front_default")]
        //public Uri FrontDefault { get; set; }

        //originais: 

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        [JsonProperty("types")]
        public List<TypeElement> Types { get; set; }
    }
}
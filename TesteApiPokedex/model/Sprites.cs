using System;
using Newtonsoft.Json;

namespace TesteApiPokedex.model
{
    public partial class Sprites
    {
        //[JsonProperty("back_default")]
        //public Uri BackDefault { get; set; }

        //[JsonProperty("back_female")]
        //public object BackFemale { get; set; }

        //[JsonProperty("back_shiny")]
        //public Uri BackShiny { get; set; }

        //[JsonProperty("back_shiny_female")]
        //public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public Uri FrontDefault { get; set; }

        //[JsonProperty("front_female")]
        //public object FrontFemale { get; set; }

        //[JsonProperty("front_shiny")]
        //public Uri FrontShiny { get; set; }

        //[JsonProperty("front_shiny_female")]
        //public object FrontShinyFemale { get; set; }

        //[JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        //public Other Other { get; set; }

        //[JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        //public Versions Versions { get; set; }

        //[JsonProperty("animated", NullValueHandling = NullValueHandling.Ignore)]
        //public Sprites Animated { get; set; }
    }
}


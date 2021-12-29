using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Globalization;
using Newtonsoft.Json;


namespace TesteApiPokedex.model
{
    public partial class Pages
{
    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("next")]
    public Uri Next { get; set; }

    [JsonProperty("previous")]
    public Uri Previous { get; set; }

    [JsonProperty("results")]
    public List<Result> Results { get; set; }
}

}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApiPokedex.model
{
    public partial class TypeElement
    {
        [JsonProperty("type")]
        public Pokemon Type { get; set; }
    }
}

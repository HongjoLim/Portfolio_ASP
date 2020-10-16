using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class BaseModel
    {
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class Link
    {
        public static Link To(string routeName, object routevalues = null) => new Link
        {
            RouteName = routeName,
            RouteValues = routevalues,
            Method = "GET",
            Relations = null
        };

        [JsonProperty(Order = -4)]
        public string Href { get; set; }

        [JsonProperty(Order = -3, PropertyName = "rel", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Relations { get; set; }

        [JsonProperty(Order  =  -2, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling  = NullValueHandling.Ignore)]
        [DefaultValue("GET")]
        public string Method { get; set; }

        // Stores the route name before being rewritten by the LinkRewritingFilter
        [JsonIgnore]
        public string RouteName { get; set; }

        // Stores the route name before being rewritten by the LinkRewritingFilter
        [JsonIgnore]
        public object RouteValues { get; set; }
    }
}

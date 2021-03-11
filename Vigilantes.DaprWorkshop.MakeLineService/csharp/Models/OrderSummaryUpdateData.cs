using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vigilantes.DaprWorkshop.MakeLineService.Models
{
    public class OrderSummaryUpdateData
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("arguments")]
        public List<OrderSummary> Arguments { get; set; }        
    }
}
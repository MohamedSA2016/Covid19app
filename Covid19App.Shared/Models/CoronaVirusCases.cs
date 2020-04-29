using System.Collections.Generic;
using Newtonsoft.Json;

namespace Covid19App.Shared.Models
{
    public class CoronaVirusCases
    {
        [JsonProperty("latest")]
        public Latest Latest { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }
    }
}
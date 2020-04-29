using Newtonsoft.Json;

namespace Covid19App.Shared.Models
{
    public class Latest
    {
        [JsonProperty("confirmed")]
        public long Confirmed { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("recovered")]
        public long Recovered { get; set; }
    }
}
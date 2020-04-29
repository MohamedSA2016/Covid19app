using System;
using Newtonsoft.Json;

namespace Covid19App.Shared.Models
{
    public class Location
    {
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("latest")]
        public Latest Latest { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }
    }
}
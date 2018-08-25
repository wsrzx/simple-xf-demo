using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChuckForms.Models
{
    public class Joke
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public List<string> Category { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

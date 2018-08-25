using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckForms.Models
{
    public class BaseModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

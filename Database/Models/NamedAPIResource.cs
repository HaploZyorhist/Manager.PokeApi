using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing name and url for the resource
    /// </summary>
    public class NamedAPIResource
    {
        /// <summary>
        /// name of the object
        /// </summary>
        [JsonPropertyName("name")]
        public string name { get; set; }

        /// <summary>
        /// url to the object
        /// </summary>
        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}

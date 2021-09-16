using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object that contains named search results
    /// </summary>
    public class Named
    {
        /// <summary>
        /// The total number of resources available from this API.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// The URL for the next page in the list.
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The URL for the previous page in the list.
        /// </summary>
        [JsonPropertyName("previous")]
        public bool? Previous { get; set; }

        /// <summary>
        /// A list of named API resources.
        /// </summary>
        [JsonPropertyName("results")]
        public List<NamedAPIResource> Results { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data on the held items on a pokemon
    /// </summary>
    public class PokemonHeldItem
    {
        /// <summary>
        /// the item referenced pokemon holds
        /// </summary>
        [JsonPropertyName("item")]
        public NamedAPIResource Item { get; set; }

        /// <summary>
        /// the details of the different versions in which the item is held
        /// </summary>
        [JsonPropertyName("version_details")]
        public PokemonHeldItemVersion VersionDetails { get; set; }
    }
}

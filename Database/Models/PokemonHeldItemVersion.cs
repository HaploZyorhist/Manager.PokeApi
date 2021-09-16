using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing held item version details
    /// </summary>
    public class PokemonHeldItemVersion
    {
        /// <summary>
        /// object containing version details
        /// </summary>
        [JsonPropertyName("version")]
        public NamedAPIResource Version { get; set; }

        /// <summary>
        /// how often the item is held
        /// </summary>
        [JsonPropertyName("rarity")]
        public int Rarity { get; set; }
    }
}

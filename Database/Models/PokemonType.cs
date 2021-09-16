using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data regarding pokemon type
    /// </summary>
    public class PokemonType
    {
        /// <summary>
        /// the order the pokemons types are listed in
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// object containing type name and url
        /// </summary>
        [JsonPropertyName("type")]
        public NamedAPIResource Type { get; set; }
    }
}

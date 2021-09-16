using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing pokemon stat data
    /// </summary>
    public class PokemonStat
    {
        /// <summary>
        /// object containing name and url for stat name
        /// </summary>
        [JsonPropertyName("stat")]
        public NamedAPIResource Stat { get; set; }

        /// <summary>
        /// the effort ports the pokemon has in the stat
        /// </summary>
        [JsonPropertyName("effort")]
        public int Effort { get; set; }

        /// <summary>
        /// the base value of the stat
        /// </summary>
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }
    }
}

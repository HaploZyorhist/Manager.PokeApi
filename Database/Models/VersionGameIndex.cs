using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data on game version and index
    /// </summary>
    public class VersionGameIndex
    {
        /// <summary>
        /// what their index was in the game
        /// </summary>
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        /// <summary>
        /// object containing version name and url
        /// </summary>
        [JsonPropertyName("version")]
        public NamedAPIResource Version { get; set; }
    }
}

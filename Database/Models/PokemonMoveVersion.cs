using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing move data for specific versions
    /// </summary>
    public class PokemonMoveVersion
    {
        /// <summary>
        /// method by which the move is learned
        /// </summary>
        [JsonPropertyName("move_learn_method")]
        public NamedAPIResource MoveLearnVersion { get; set; }

        /// <summary>
        /// the version group in which the move is learned
        /// </summary>
        [JsonPropertyName("version_group")]
        public NamedAPIResource VersionGroup { get; set; }

        /// <summary>
        /// the minimum level to learn the move
        /// </summary>
        [JsonPropertyName("level_learned_at")]
        public int LevelLearnedAt { get; set; }
    }
}

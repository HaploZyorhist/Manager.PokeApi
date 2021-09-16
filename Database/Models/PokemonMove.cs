using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data on pokemon moves
    /// </summary>
    public class PokemonMove
    {
        /// <summary>
        /// object containing the name and url of the move that the pokemon can learn
        /// </summary>
        [JsonPropertyName("move")]
        public NamedAPIResource Move { get; set; }

        /// <summary>
        /// the details of the version in which the pokemon can learn the move
        /// </summary>
        [JsonPropertyName("version_group_details")]
        public List<PokemonMoveVersion> VersionGroupDetails { get; set; }
    }
}

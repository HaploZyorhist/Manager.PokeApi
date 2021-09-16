using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data on pokemon abilities
    /// </summary>
    public class PokemonAbility
    {
        /// <summary>
        /// is a hidden ability
        /// </summary>
        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// slot the ability belongs in
        /// </summary>
        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        /// <summary>
        /// object containing ability name and uri
        /// </summary>
        [JsonPropertyName("ability")]
        public NamedAPIResource Ability { get; set; }
    }
}

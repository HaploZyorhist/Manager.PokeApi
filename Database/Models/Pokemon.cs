using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing return data for a pokemon queried
    /// </summary>
    public class Pokemon
    {
        /// <summary>
        /// Pokedex id (national dex)
        /// </summary>
        [JsonPropertyName("id")]
        public int ID { get; set; }

        /// <summary>
        /// name of the pokemon
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// base experience granted for defeating
        /// </summary>
        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        /// <summary>
        /// pokemon's height
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Set for exactly one pokemon used as the default for each species
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Order for sorting. Alsmost national order, except families are grouped together
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }

        /// <summary>
        /// weight of the pokemon in hectrograms
        /// </summary>
        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// a list of abilities this pokemon could potentially have
        /// </summary>
        [JsonPropertyName("abilities")]
        public List<PokemonAbility> Abilities { get; set; }

        /// <summary>
        /// a list of game indices relevent to pokmeon item by generation
        /// </summary>
        [JsonPropertyName("game_indices")]
        public List<VersionGameIndex> GameIndices { get; set; }

        /// <summary>
        /// a list of items this pokmeon may be holding when encountered
        /// </summary>
        [JsonPropertyName("held_items")]
        public List<PokemonHeldItem> HeldItems { get; set; }

        /// <summary>
        /// a link to a list of location areas, as well as encounter details pertaining to specific versions
        /// </summary>
        [JsonPropertyName("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        /// <summary>
        /// a list of pokemon moves
        /// </summary>
        [JsonPropertyName("moves")]
        public List<PokemonMove> Moves { get; set; }

        /// <summary>
        /// a set of sprites used to depict this pokemon in the game
        /// </summary>
        [JsonPropertyName("sprites")]
        public PokemonSprites Sprites { get; set; }

        /// <summary>
        /// the species this pokemon belongs to
        /// </summary>
        [JsonPropertyName("species")]
        public NamedAPIResource Species { get; set; }

        /// <summary>
        /// a list of base stat values for this pokemon
        /// </summary>
        [JsonPropertyName("Stats")]
        public List<PokemonStat> Stats { get; set; }

        /// <summary>
        /// the types that the pokemon belongs to
        /// </summary>
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; }
    }
}
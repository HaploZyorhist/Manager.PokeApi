using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Manager.PokeApi.Database.Models
{
    /// <summary>
    /// object containing data on the pokemon sprites
    /// </summary>
    public class PokemonSprites
    {
        /// <summary>
        /// default depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        /// <summary>
        /// shiny depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; }

        /// <summary>
        /// female depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; }

        /// <summary>
        /// female shiny depiction of the pokemon from the front
        /// </summary>
        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; }

        /// <summary>
        /// default depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; }

        /// <summary>
        /// shiny depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; }

        /// <summary>
        /// female depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; }

        /// <summary>
        /// female shiny depiction of the pokemon from the back
        /// </summary>
        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; }
    }
}

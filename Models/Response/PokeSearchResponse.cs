using Manager.PokeApi.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Models.Response
{
    /// <summary>
    /// object that contains response from pokemon search
    /// </summary>
    public class PokeSearchResponse
    {
        /// <summary>
        /// list of error messages
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// list of pokemon found in the search
        /// </summary>
        public List<PokemonBase> PokemonList { get; set; }
    }
}

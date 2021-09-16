using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Models.Response
{
    /// <summary>
    /// object that contains data on pokemon search results
    /// </summary>
    public class PokemonBase
    {
        /// <summary>
        /// name of pokemon being searched
        /// </summary>
        public string PokemonName { get; set; }

        /// <summary>
        /// id of pokemon being searched
        /// </summary>
        public int PokemonID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Models.Response
{
    /// <summary>
    /// object containing pokemon details
    /// </summary>
    public class PokeDetailResponse
    {
        /// <summary>
        /// list of errors for getting pokemon details
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// object contatining pokemon data 
        /// </summary>
        public PokemonDetails PokemonDetails { get; set; }
    }
}

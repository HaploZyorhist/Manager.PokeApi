using Manager.PokeApi.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Services.Interfaces
{
    /// <summary>
    /// interface for dealing with pokemon service
    /// </summary>
    public interface IPokemonService
    {
        /// <summary>
        /// method for getting list of pokemon searched
        /// </summary>
        /// <param name="pokemonName"></param>
        /// <returns>list (up to 10) of pokemon who match search criteria</returns>
        Task<PokeSearchResponse> GetPokemonList(string pokemonName);

        /// <summary>
        /// method for getting details on selected pokemon
        /// </summary>
        /// <param name="pokemonName"></param>
        /// <returns>object containing pokemon details</returns>
        Task<PokeDetailResponse> GetPokemonDetail(int pokemonID);
    }
}

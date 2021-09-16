using Flurl;
using Flurl.Http;
using Manager.PokeApi.Database.Models;
using Manager.PokeApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Services
{
    /// <summary>
    /// Service for handling Pokemon related requests
    /// </summary>
    public class PokemonService : IPokemonService
    {
        public async Task GetPokemonList (string pokemonName)
        {
            try
            {
                // TODO: make environmental variable
                var pokemon = await "https://pokeapi.co/api/v2/"
                    .AppendPathSegment($"pokemon/")
                    .SetQueryParam("limit=1120")
                    .GetJsonAsync<Named>();

                List<NamedAPIResource> pokmeonList = pokemon.Results;

                var stop = 1;

            }
            catch(Exception ex)
            {
            }
        }
    }
}

using Flurl;
using Flurl.Http;
using Manager.PokeApi.Database.Models;
using Manager.PokeApi.Models.Response;
using Manager.PokeApi.Models.Components;
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
        #region Fields

        private string _apiURL;

        #endregion

        #region CTOR

        public PokemonService()
        {
            _apiURL = Environment.GetEnvironmentVariable("APIConnectionURL");
        }

        #endregion

        #region Services

        /// <inheritdoc />
        public async Task<PokeSearchResponse> GetPokemonList(string pokemonName)
        {
            PokeSearchResponse response = new PokeSearchResponse
            {
                Errors = new List<string>(),
                PokemonList = new List<PokemonBase>()
            };
            try
            {
                var pokemon = await _apiURL
                    .AppendPathSegment($"pokemon/")
                    .SetQueryParam("limit=1120")
                    .GetJsonAsync<Named>();

                if(pokemon == null ||
                   pokemon.Results == null)
                {
                    throw new Exception("No pokemon were returned");
                }

                List<NamedAPIResource> pokeList = pokemon.Results;

                var filteredPokemon = (from poke in pokeList
                                       where poke.name.Contains(pokemonName)
                                       orderby poke.name
                                       select new PokemonBase
                                       {
                                           PokemonName = poke.name,
                                           PokemonID = int.Parse(poke.url.Split("/")[6])
                                       }).Take(10).ToList();

                if (filteredPokemon.Count < 1)
                {
                    throw new Exception($"There were no matches for {pokemonName}");
                }

                response.PokemonList.AddRange(filteredPokemon);

                return response;
            }
            catch (Exception ex)
            {
                response.Errors.Add(ex.Message);
                return response;
            }
        }

        /// <inheritdoc />
        public async Task<PokeDetailResponse> GetPokemonDetail(int pokemonID)
        {
            PokeDetailResponse pokemonReturn = new PokeDetailResponse
            {
                Errors = new List<string>(),
                PokemonDetails = new PokemonDetails
                {
                     Abilities = new List<PAbility>(),
                     Moves = new List<PMove>(),
                     Sprites = new Sprites()
                }
            };

            try
            {
                var pokemon = await _apiURL
                     .AppendPathSegment($"pokemon/{pokemonID}")
                     .GetJsonAsync<Pokemon>();

                PokemonDetails details = new PokemonDetails
                {
                    PokemonName = pokemon.Name,
                };

                return pokemonReturn;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        #endregion
    }
}

using Manager.PokeApi.Database.Models;
using Manager.PokeApi.Models.Response;
using Manager.PokeApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PokemonController : ControllerBase
    {
        #region Fields

        private readonly IPokemonService _poke;

        #endregion

        #region CTOR

        public PokemonController(IPokemonService poke)
        {
            _poke = poke;
        }

        #endregion

        #region Calls

        /// <summary>
        /// Api Call for a list of pokemon names that match search box entry
        /// </summary>
        /// <returns>object containing a list of 10 pokemon that match search entry</returns>
        [HttpGet("PokemonNameList/{pokemonName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SearchResult<PokemonBase>>> GetPokemonList (string pokemonName)
        {
            try
            {
                var pokemonReturn = await _poke.GetPokemonList(pokemonName);

                if(pokemonReturn.Errors.Count > 0)
                {
                    throw new Exception(string.Join(", ", pokemonReturn.Errors));
                }

                var listReturn = pokemonReturn.PokemonList;

                return Ok(new SearchResult<PokemonBase>
                {
                    Count = listReturn.Count,
                    Next = null,
                    Previous = null,
                    Results = listReturn
                });
            }
            catch(Exception ex)
            {
                //log ex.message to your error logs
                return BadRequest();
            }
        }

        /// <summary>
        /// Api Call for a data on the selected pokemon
        /// </summary>
        /// <returns>object containing pokemon data</returns>
        [HttpGet("PokemonDetail/{pokemonID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SearchResult<PokemonDetails>>> GetPokemon (int pokemonID)
        {
            try
            {
                PokemonDetails response = new PokemonDetails();

                var pokemonDetailSearch = await _poke.GetPokemonDetail(pokemonID);

                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        #endregion
    }
}

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
        public async Task<ActionResult> GetPokemonList (string pokemonName)
        {
            try
            {
                await _poke.GetPokemonList(pokemonName);

                //TODO: Version Control

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        #endregion
    }
}

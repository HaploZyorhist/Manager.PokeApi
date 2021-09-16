using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Services.Interfaces
{
    public interface IPokemonService
    {
        Task GetPokemonList(string pokemonName);

    }
}

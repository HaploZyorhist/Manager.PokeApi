using Manager.PokeApi.Models.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manager.PokeApi.Models.Response
{
    /// <summary>
    /// Object containing details on the pokemon searched
    /// </summary>
    public class PokemonDetails
    {
        public string PokemonName { get; set; }

        public List<PAbility> Abilities { get; set; }

        public List<PMove> Moves { get; set; }

        public bool IsBaby { get; set; }

        public bool IsLegendary { get; set; }

        public bool IsMythic { get; set; }

        public int GenderRate { get; set; }

        public int EncounterRate { get; set; }

        public Sprites Sprites { get; set; }
    }
}

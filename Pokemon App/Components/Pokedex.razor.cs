using Microsoft.AspNetCore.Components;
using Pokemon_App.Models;
using System.Collections.Generic;

namespace Pokemon_App.Components
{
    public partial class Pokedex
    {
        [Parameter]
        public List<Pokemon> Pokemons { get; set; }

        [Parameter]
        public int TotalExp { get; set; }

        [Parameter]
        public bool IsWinner { get; set; }
    }
}

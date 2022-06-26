using Pokemon_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_App.Components
{
    public partial class Pokegame
    {

        private List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon(){Id = 4, Name = "Charmander", Type = "Fire", Exp = 62},
            new Pokemon(){Id = 7, Name = "Squirtle", Type = "Water", Exp = 63},
            new Pokemon(){Id = 11, Name = "Metapod", Type = "Buck", Exp = 72},
            new Pokemon(){Id = 12, Name = "Butterfree", Type = "Flying", Exp = 178},
            new Pokemon(){Id = 25, Name = "Pikachu", Type = "Electric", Exp = 112},
            new Pokemon(){Id = 39, Name = "Jigglypuff", Type = "Normal", Exp = 95},
            new Pokemon(){Id = 94, Name = "Gengar", Type = "Poison", Exp = 225},
            new Pokemon(){Id = 133, Name = "Eevee", Type = "Normal", Exp = 65}

        };

        protected List<Pokemon> firstPokedex;
        protected List<Pokemon> secondPokedex;
        protected int firstPokedexTotal;
        protected int secondPokedexTotal;
        protected bool isFirstWinner;

        protected override void OnInitialized()
        {

            firstPokedex = new List<Pokemon>();
            secondPokedex = new List<Pokemon>();
            var rand = new Random();
            var pokemonsHalfCount = pokemons.Count / 2;
            for (int i = 0; i < pokemonsHalfCount; i++)
            {
                var pokemon = pokemons[rand.Next(0,pokemons.Count)];
                firstPokedex.Add(pokemon);
                pokemons.Remove(pokemon);
            }
            secondPokedex = pokemons;

            firstPokedexTotal = firstPokedex.Select(x => x.Exp).Sum();
            secondPokedexTotal = secondPokedex.Select(x => x.Exp).Sum();
            isFirstWinner = firstPokedexTotal > secondPokedexTotal ? true : false;
        }

    }
}

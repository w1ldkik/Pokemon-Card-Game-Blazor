using Microsoft.AspNetCore.Components;
using Pokemon_App.Models;

namespace Pokemon_App.Components
{
    public partial class Pokecard
    {
        private const string PokeAPI = "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/";
        protected string ImageSource { get; set; }

        [Parameter]
        public Pokemon Pokemon { get; set; } 
        private void FormattingImageSource()
        {
            if (Pokemon.Id < 10)
            {
                ImageSource = $"{PokeAPI}00{Pokemon.Id}.png";
            }
            else
            {
                if (Pokemon.Id < 100 && Pokemon.Id >= 10)
                {
                    ImageSource = $"{PokeAPI}0{Pokemon.Id}.png";
                }
                else
                {
                    ImageSource = $"{PokeAPI}{Pokemon.Id}.png";
                }
            }
        }
        protected override void OnInitialized()
        {
            FormattingImageSource();
        }
    }
}

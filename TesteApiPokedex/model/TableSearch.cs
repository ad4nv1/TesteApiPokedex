using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using TesteApiPokedex.viewModel;

namespace TesteApiPokedex.model
{
    class TableSearch
    {
        public static long id { get; set; }
        public static string name { get; set; }
        public static string type { get; set; }
        public static long height { get; set; }
        public static long weight { get; set; }
        public static string image { get; set; }

        public TableSearch(){}


        public static async Task GetRequerimentPokemonInApi(string namePokemon)
        {
            var dataPokemon = RestService.For<PokemonApiService>("https://pokeapi.co/api/v2");

            //var poke = await dataPokemon.GetPokemonAsync(namePokemon);

            //id = poke.Id;

            //name = poke.Name;

            //type = poke.Types[0].Type.Name;

            //height = poke.Height;

            //weight = poke.Weight;

            //image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + poke.Id + ".png";

            //DbClass.Add(poke.Id, poke.Name, poke.Types[0].Type.Name, poke.Height, poke.Weight, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + poke.Id + ".png");

        }

    }
}

using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApiPokedex.model;

namespace TesteApiPokedex.viewModel
{
    class QueryPokemon
    {
        private  long id;
        private String name;
        private string type;
        public static string joao { get; set; }
        public static  async Task GetConsultaPokemon(string namePokemon)
        {
            //try
            //{ 
                var dataPokemon = RestService.For<PokemonApiService>("https://pokeapi.co/api/v2");


               // var poke = await dataPokemon.GetPokemonAsync(namePokemon);



          //  joao =  "\n " + poke.Id + "\n " + poke.Name + "\n " + poke.Types;
           // Console.WriteLine("\n " + poke.Id + "\n " + poke.Name + "\n " + poke.Types + "\n " + poke.sprites);
        }
        //catch (Exception e)
        //{
        //    Console.WriteLine("pokemon não encontrado" + e.Message);
        //}
        // }

    }
}

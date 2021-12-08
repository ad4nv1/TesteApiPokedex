using System;
using System.Threading.Tasks;
using TesteApiPokedex.viewModel;
using TesteApiPokedex.model;
using Refit;
using System.Data;
using System.Data.SQLite;



namespace TesteApiPokedex
{
    
    class Program
    {

        //public static void Main(string[] args)
        static async Task Main(string[] args)
        {

            

            //Console.WriteLine(DbClass.GetPokemon().Rows[0].ItemArray[1]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[0].ItemArray[2]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[1].ItemArray[1]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[1].ItemArray[2]);


            Console.WriteLine("Digite o nome ou o id do pokemon: ");
            String namePokemon = Console.ReadLine();

            //operations.RegisterPokemon(namePokemon);
            
            //Console.WriteLine(QueryPokemon.GetConsultaPokemon(namePokemon));

            var dataPokemon = RestService.For<PokemonApiService>("https://pokeapi.co/api/v2");
            var poke = await dataPokemon.GetPokemonAsync(namePokemon);

            Console.WriteLine("\n " + poke.Id 
                + "\n "+ poke.Name 
                + "\n " + poke.Types
                + "\n "+ poke.Sprites.FrontDefault
                + "\n " + "altura: "+poke.Height
                + "\n " + "pra que(other)? "+poke.Order
                + "\n " + "stats" + poke.Stats
                + "\n " + "peso: " +poke.Weight);

            //Console.WriteLine("Digite o nome que deseja pesquisar: ");
            //String name = Console.ReadLine();
            //Console.WriteLine(DbClass.consulta(name).Rows[0].ItemArray[1]);
            //Console.WriteLine(DbClass.consulta(name).Rows[0].ItemArray[2]);


            //Console.WriteLine("coloque um numero de identificação: ");
            //string v = Console.ReadLine();
            //long id = Convert.ToInt64(v);
            //Console.WriteLine("coloque um nome para aparecer: ");
            //string namePokemonAdd = Console.ReadLine();
            //DbClass.Add(id, namePokemonAdd);




        }
    }
}

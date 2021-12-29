using System;
using System.Threading.Tasks;
using TesteApiPokedex.viewModel;
using TesteApiPokedex.model;
using Refit;
using System.Data;
using System.Data.SQLite;
using System.Net;
using System.IO;

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TesteApiPokedex
{

    class Program
    {

        //public static void Main(string[] args)
        //static async Task Main(string[] args)
        static async Task Main(string[] args)
        {



            //Console.WriteLine(DbClass.GetPokemon().Rows[0].ItemArray[1]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[0].ItemArray[2]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[1].ItemArray[1]);
            //Console.WriteLine(DbClass.GetPokemon().Rows[1].ItemArray[2]);




            //==========================================================


            //Console.WriteLine("Digite o nome ou o id do pokemon: ");
            //String namePokemon = Console.ReadLine();

            //==========================================================





            //operations.RegisterPokemon(namePokemon);











            // TableSearch.GetRequerimentPokemonInApi(namePokemon);

            //Console.WriteLine(TableSearch.id+ TableSearch.name+ TableSearch.type+ TableSearch.height+ TableSearch.weight+ TableSearch.image);


            //DbClass.Add(TableSearch.id, TableSearch.name, TableSearch.type, TableSearch.height, TableSearch.weight, TableSearch.image);




            //operations.RegisterPokemon(namePokemon);

            //Console.WriteLine(QueryPokemon.GetConsultaPokemon(namePokemon));

            //==========================================================


            var dataPokemon = RestService.For<PokemonApiService>("https://pokeapi.co/api/v2");
            //var poke = await dataPokemon.GetPokemonAsync(namePokemon);



            //string urlsprite = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + poke.Id + ".png";


            //==========================================================

            var page = await dataPokemon.GetPagesAsync(40);

            //for (int i = 0; i < 10; i++)
            //{
            //    var poke = await dataPokemon.GetPokemonAsync(page.Results[i].Name);
            //    Console.WriteLine("\n " + poke.Id
            //    + "\n " + poke.Name
            //    + "\n " + poke.Types[0].Type.Name //Retorna o valor esperado 
            //    //+ "\n " + poke.Stats[0].StatStat.Name //Não retorna o valor
            //    + "\n " + "altura: " + poke.Height
            //    + "\n " + "peso" + poke.Weight
            //    + "\n " + "image" + "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + poke.Id + ".png");
            //    DbClass.Add(poke.Id, poke.Name, poke.Types[0].Type.Name, poke.Height, poke.Weight, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + poke.Id + ".png");

            //}


















            //==========================================================




            //Console.WriteLine("\n " + poke.Id
            //    + "\n " + poke.Name
            //    + "\n " + poke.Types[0].Type.Name
            //    + "\n " + poke.Stats[1].Base.ToString()
            //    + "\n " + poke.Stats[1].Effort.ToString()
            //    + "\n " + "altura: " + poke.Height
            //    + "\n " + "peso: " + poke.Weight
            //    + "\n " + "imagem: " + urlsprite);




            //==========================================================

            //for(int i=0; i< poke.Types.Count; i++)
            //{
            //    Console.WriteLine("\n "  + poke.Types[i].Type.Name);
            //}
            //for (int i = 0; i < poke.Stats.Count; i++)
            //{
            //    Console.WriteLine(poke.Stats[i].Base);
            //}


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


            //Console.WriteLine("Digite o nome ou o id do pokemon: ");
            //String namePokemon = Console.ReadLine();

            //ShowData(namePokemon);
            //Console.ReadKey();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[1] 
                + " " + DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[2]
                + " " + DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[3]
                + " " + DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[4]
                + " " + DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[5]
                + " " + DbClass.consulta(page.Results[i].Name).Rows[0].ItemArray[6]
                +" \n ");

            } 
        }

        static void ShowData(string pokemon)
        {
            var json = GetJSON(pokemon);
            var data = JsonConvert.DeserializeObject<Form>(json);
            
                Console.WriteLine(data.Id + " " + data.Name + " "+ data.Stats[0].Effort +" "+ data.Stats[0].Base + " " + data.Stats[0].StatStat.Name);
            
        }

        static string GetJSON(string pokemon)
        {
            var request = WebRequest.Create("https://pokeapi.co/api/v2/pokemon/"+pokemon);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if(response.StatusCode == HttpStatusCode.OK)
            {
                using(var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json;
                }
            }
            return null;
        }
    }
}

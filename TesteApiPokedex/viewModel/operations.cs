using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApiPokedex.model;
namespace TesteApiPokedex.viewModel
{
    class operations
    {
        public static async void RegisterPokemon(string name)
        {
            await TableSearch.GetRequerimentPokemonInApi(name);

            await DbClass.Add(TableSearch.id, TableSearch.name, TableSearch.type, TableSearch.height, TableSearch.weight, TableSearch.image);

        }

        public static async void Verificate(string name)
        {
            if (DbClass.consulta(name).Rows.Count == 1)
            {
                

            }

            

        }
    }
}

using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApiPokedex.model;

namespace TesteApiPokedex.viewModel
{
    public interface PokemonApiService
    {
        [Get("/pokemon/{name}")]
        Task<Form> GetPokemonAsync(string name);
    }

}
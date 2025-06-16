using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_tamagotchi_cli
{
    internal class PokemonApiService
    {
        public List<PokemonResult> ObterEspeciesDisponiveis()
        {
            var client = new RestClient("https://pokeapi.co/api/v2/pokemon-species/");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);
            var pokemonEspeciesResposta = JsonConvert.DeserializeObject<PokemonSpecies>(response.Content);

            return pokemonEspeciesResposta.Results;

        }

        public Mascote ObterDetalhesDaEspecie(PokemonResult especie)
        {
            // Obter as características do Pokémon escolhido
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie.Name}");
            var request = new RestRequest("", Method.Get);
            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<Mascote>(response.Content);

        }
    }
}

// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;
using pokemon_tamagotchi_cli;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

var client  =  new RestClient("https://pokeapi.co/api/v2/pokemon-species/");
var request = new RestRequest("", Method.Get);
var response = client.Execute(request);


var pokemonSpecies = JsonConvert.DeserializeObject<PokemonSpecies>(response.Content);

Console.WriteLine("Escolha um pokemon: ");


for(int i = 0; i < pokemonSpecies.Results.Count; i++)
{
    Console.WriteLine($"{i + 1} - {pokemonSpecies.Results[i].Name}");
}

int escolha;

while(true)
{
    Console.Write("Escolha um numero: ");

    if (!int.TryParse(Console.ReadLine(), out escolha) && escolha >= 1 && escolha <= pokemonSpecies.Results.Count)
    { 
        Console.WriteLine("Escolha invalida, tente novamente.");    
    }
    else
    {
        break;
    }
}


client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{escolha}");
request = new RestRequest("", Method.Get);
response = client.Execute(request);


if (response.Content != null)
{
    Mascote mascote = JsonConvert.DeserializeObject<Mascote>(response.Content) ?? new Mascote();
    Console.WriteLine(mascote);
}
else
{
    Console.WriteLine("Erro: Não foi possível obter os dados do Pokémon.");
}





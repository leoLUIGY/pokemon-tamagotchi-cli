// See https://aka.ms/new-console-template for more information


using RestSharp;

var client  =  new RestClient("https://pokeapi.co/api/v2/pokemon/");
var request = new RestRequest("", Method.Get);

var response = client.Execute(request);

if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Console.WriteLine(response.Content);
    
}
else 
{
    Console.WriteLine($"Error: {response.StatusCode} - {response.ErrorMessage}");
}



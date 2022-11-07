using Restaurante.DTOs;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace Restaurante.Services
{
    public class BuscarRestaurantesService : IBuscarRestaurantesService
    {
        private readonly HttpClient _httpClient;

        public BuscarRestaurantesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Find()
        {
            Console.WriteLine("ADASDASDSADASDAS");
            var response = await _httpClient.GetAsync("https://localhost:7217/Restaurante/restaurante/todos");
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            return jsonResult;
        }
    }
}
using Restaurante.DTOs;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Restaurante.Services
{
    public class BuscarRestaurantesService : IBuscarRestaurantesService
    {
        private readonly HttpClient _httpClient;

        public BuscarRestaurantesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RestauranteDTO>> Find()
        {
            var response = await _httpClient.GetAsync("https://localhost:7217/Restaurante/restaurante/todos");
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(jsonResult);
            var r = json.SelectToken("data")[0].ToString();
            List<RestauranteDTO> restaurantes = new List<RestauranteDTO>();

            for (int i = 0; i < json.SelectToken("data").Count(); i++)
            {
                restaurantes.Add(new RestauranteDTO(json.SelectToken("data")[i].SelectToken("nome").ToString(),
                                Convert.ToInt32(json.SelectToken("data")[i].SelectToken("cozinha"))));
            }

            return restaurantes;
        }
        public async Task<string> FindById(string id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7217/Restaurante/restaurante/byid/{id}");
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            return jsonResult;
        }
    }
}

using Restaurante.DTOs;

namespace Restaurante.Services
{
    public class BuscarRestaurantesService
    {
        private readonly HttpClient _httpClient;

        public BuscarRestaurantesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RestauranteDTO>> Find(DateTime startData)
        {
            
        }
    }
}
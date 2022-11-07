using Newtonsoft.Json.Linq;
using Restaurante.DTOs;

namespace Restaurante.Services
{
    public interface IBuscarRestaurantesService
    {
        Task<List<RestauranteDTO>> Find();
    }
}

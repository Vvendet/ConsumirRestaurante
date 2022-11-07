using Restaurante.DTOs;

namespace Restaurante.Services
{
    public interface IBrowserService
    {
        Task<BrowserDimension> GetDimensions();
    }
}

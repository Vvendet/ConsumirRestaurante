using Microsoft.JSInterop;
using Restaurante.DTOs;
using System.Threading.Tasks;
namespace Restaurante.Services
{
    public class BrowserService : IBrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {

            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }

    }
    
}

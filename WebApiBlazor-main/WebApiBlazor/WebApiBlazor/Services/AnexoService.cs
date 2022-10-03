using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
    public class AnexoService : IAnexoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public AnexoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        

        public async Task<IEnumerable<Anexo>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Anexos");
            return JsonSerializer.Deserialize<IEnumerable<Anexo>>(resp, options);
        }

   
    }
}

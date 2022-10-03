using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
    public class ExamenService : IExamenService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public ExamenService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Examen>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Examenes");
            return JsonSerializer.Deserialize<IEnumerable<Examen>>(resp, options);
        }

      

        
    }
}

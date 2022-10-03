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
    public class PacienteService : IPacienteService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public PacienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        
        public async Task<IEnumerable<Paciente>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Paciente");

            return JsonSerializer.Deserialize<IEnumerable<Paciente>>(resp, options);
        }

     
    }
}

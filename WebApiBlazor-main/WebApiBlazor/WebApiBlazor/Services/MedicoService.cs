using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
    public class MedicoService : IMedicoService
    {
        //inyeccion de dependicias de HttpClient
        private readonly HttpClient _httpClient;

        public MedicoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //configurar las opciones del Serializador
        

        public async Task<IEnumerable<Medico>> GetAll()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Medicos");
            return JsonSerializer.Deserialize<IEnumerable<Medico>>(resp, options);
        }

        public async Task<Medico> GetById(int id)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Medico/{id}");
            return JsonSerializer.Deserialize<Medico>(resp, options);
        }
    }
}

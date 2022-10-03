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
    public class HorarioService : IHorarioService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public HorarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Horario>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Horario");
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(resp, options);
        }

        public async Task<Horario> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Horario/{id}");
            return JsonSerializer.Deserialize<Horario>(resp, options);
        }

        public async Task<IEnumerable<Horario>> GetByMedico(int idMedico)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Horario/Buscar", new { idMedico = idMedico });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(respString, options);
        }
    }
}

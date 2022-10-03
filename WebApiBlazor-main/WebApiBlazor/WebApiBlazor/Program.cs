using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApiBlazor.Services;

namespace WebApiBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44371/api/") });
            builder.Services.AddScoped<IMedicoService, MedicoService>();
            builder.Services.AddScoped<IAnexoService, AnexoService>();
            builder.Services.AddScoped<IExamenService, ExamenService>();
            builder.Services.AddScoped<IHorarioService, HorarioService>();
            builder.Services.AddScoped<IPacienteService, PacienteService>();
            builder.Services.AddMudServices();
 
            await builder.Build().RunAsync();
        }
    }
}

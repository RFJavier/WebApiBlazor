using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
   public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetAll();
      
        
    }
}

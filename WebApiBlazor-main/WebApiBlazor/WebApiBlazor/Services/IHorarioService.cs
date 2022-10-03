using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
   public interface IHorarioService
    {
        Task<IEnumerable<Horario>> GetAll();
  
    }
}

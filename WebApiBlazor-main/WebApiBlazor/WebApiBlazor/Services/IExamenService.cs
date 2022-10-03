using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBlazor.Models;

namespace WebApiBlazor.Services
{
   public interface IExamenService
    {
        Task<IEnumerable<Examen>> GetAll();
    }
}

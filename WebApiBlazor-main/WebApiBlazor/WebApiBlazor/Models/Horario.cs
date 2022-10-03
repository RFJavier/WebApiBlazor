using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBlazor.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int idMedico { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
    }
}

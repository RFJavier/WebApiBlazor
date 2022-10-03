using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBlazor.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public int IdMedico { get; set; }
        public int IdExamen { get; set; }
        public int IdAnexo { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Genero { get; set; }
    }
}

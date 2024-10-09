using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiseñoLogin.Entidades
{
    public class E_Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public DateTime FechaInsc { get; set; }
        public bool EntregoAptoFisico { get; set; }
    }

    public class E_Socio : E_Cliente
    {
        public int IdSocio { get; set; }
        public string Estado { get; set; }
        public bool EstaHabilitado { get; set; }
        public int MesCuota { get; set; }
    }
}

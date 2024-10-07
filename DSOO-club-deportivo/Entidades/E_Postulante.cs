using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiseñoLogin.Entidades
{
    public class E_Postulante
    {
        public int NPostu { get; set; }
        public string? NombreP { get; set; }
        public string? ApellidoP { get; set; }
        public string? TDocP { get; set; }
        public int DocP { get; set; }
        public DateTime? FechaNac { get; set; }
        public DateTime? FechaInsc { get; set; }

        public bool EntregoAF { get; set; }


    }
}

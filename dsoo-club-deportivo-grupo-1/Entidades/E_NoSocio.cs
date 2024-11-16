using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public int IdNoSocio { get; set; }
        public bool EstaHabilitado { get; set; }

        // Atributo que representa una lista de nombres de actividades
        public List<string> Actividades { get; set; }

        // Constructor
        public E_NoSocio()
        {
            // Inicializar la lista para evitar null reference exceptions
            Actividades = new List<string>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Capa_Entidad
{
    public class cliente
    {
        public int idc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int idprestamo { get; set; }
      
    }
    public class Prestamos{

        public int idprestamo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int monto { get; set; }
        public int cuota { get; set; }
        public int tiempo { get; set; }

        public DateTime fecha { get; set; }

        public int interes { get; set; }
        public int monto_total { get; set; }
    }
}


    



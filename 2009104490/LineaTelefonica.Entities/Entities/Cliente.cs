using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Cliente
    {
        public int idCliente { set; get; }
        public String Dni { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String telf_contacto { set; get; }
        public String correo { set; get; }
        public String direccion { set; get; }

        public List<Evaluacion> ListEvaluaciones { set; get; }
        public List<Venta> ListVentas { set; get; }
        
    }
}

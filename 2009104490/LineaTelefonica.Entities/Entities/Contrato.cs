using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Contrato
    {
        public int idContrato { set; get; }
        public DateTime fechainicio { set; get; }
        public DateTime fechafin { set; get; }

        public List<Venta> ventas { set; get; }
        
    }
}

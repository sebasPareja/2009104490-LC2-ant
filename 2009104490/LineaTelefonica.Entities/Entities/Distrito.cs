using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Distrito
    {
        public int idDistrito { set; get; }
        public String nombreDistrito { set; get; }

        public Provincia provincia { set; get; }
        public int idProvincia { set; get; }

        //public List<Ubigeo> ubigeos { set; get; }
        public Ubigeo ubigeo { set; get; }
    }
}

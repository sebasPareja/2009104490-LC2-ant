using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Ubigeo
    {
        public int idUbigeo { set; get; }

        public Distrito distrito { set; get; }
        public int idDistrito { set; get; }

        public Provincia provincia { set; get; }
        public int idProvincia { set; get; }
        
        public Departamento departamento { set; get; }
        public int idDepartamento { set; get; }

        public List<Direccion> ListaDireccion { set; get; }

    }
}

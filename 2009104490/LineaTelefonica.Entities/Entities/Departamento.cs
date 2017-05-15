using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Departamento
    {
        public int idDepartamento { set; get; }
        public String nombreDepartamento { set; get; }

        public List<Distrito> ListaDistritos { set; get; }
        public List<Provincia> ListaProvincias { set; get; }

        //public List<Ubigeo> ubigeos { set; get; }
        public Ubigeo ubigeo { set; get; }
       
    }
}

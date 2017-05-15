using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Provincia
    {
        public int idProvincia { set; get; }
        public String nombreProvincia { set; get; }
        public Departamento departamento { set; get; }
        public int idDepartamento { set; get; }

        public List<Distrito> ListDistritos { set; get; }

        //public List<Ubigeo> ubigeos { set; get; }
        public Ubigeo ubigeo { set; get; }
    }
}

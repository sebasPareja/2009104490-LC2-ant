using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Direccion
    {
        public int idDireccion { set; get; }
        public Ubigeo ubigeo { set; get; }
        public int idUbigeo { set; get; }
        public String Descripcion { set; get; }
        public CentroAtencion centroatencion { set; get; }
        
    }
}

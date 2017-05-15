using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class LineaTelefonica
    {
        public int idLineaTelefonica { set; get; }
        public TipoLinea tipolinea { set; get; }
        public String nroCelular { set; get; }

        public AdministradorLinea administradorLinea { set; get; }
        public int idAdministradorLinea { set; get; }        

    }
}

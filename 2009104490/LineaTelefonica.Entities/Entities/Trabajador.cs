using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Trabajador
    {
        public int idTrabajador { set; get; }
        public TipoTrabajador tipotrabajador { set; get; }
        public byte idTipoTrabajador { set; get; }

        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String login { set; get; }
        public String password { set; get; }


        public List<Evaluacion> ListEvaluaciones { set; get; }
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Evaluacion
    {
        public int idEvaluacion { set; get; }
        public LineaTelefonica lineaTelefonica { set; get; }
        public int idLineaTelefonica { set; get; }

        public EquipoCelular equipo{set;get;}
        public int idEquipoCelular { set; get; }

        public Plan plan { set; get; }
        public int idPlan { set; get; }

        public Trabajador trabajador { set;get; }
        public int idTrabajador { set; get; }

        public TipoEvaluacion tipoevaluacion { set; get; }

        public EstadoEvaluacion estado{set;get;}

        public Cliente cliente{set;get;}
        public int idCliente { set; get;}

        //public List<Venta> ventas { set; get; }
        public Venta venta { set; get; }

        public DateTime fechaEvaluacion { set; get; }

        

    }
}

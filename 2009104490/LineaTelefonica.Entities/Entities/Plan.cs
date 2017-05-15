using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Plan
    {
        public int idPlan { set; get; }
        public TipoPlan tipoplan { set; get; }
        public byte idTipoPlan { set; get; }
        public String restricciones { set; get; }

        
    }
}

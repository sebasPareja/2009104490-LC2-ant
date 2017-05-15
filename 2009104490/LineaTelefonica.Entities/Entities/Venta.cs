﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class Venta
    {
        public int idVenta { set; get; }

        public Cliente cliente { set; get; }
        public int idCliente { set; get; }

        public TipoPago tipopago {set;get;}

        public Contrato contrato{set;get;}
        public int idContrato { set; get; }

        public LineaTelefonica lineaTelefonica { set; get; }
        public int idLineaTelefonica { set; get; }

        public DateTime fechaVenta { set; get; }
        
        public Evaluacion evaluacion { set; get; }
        public int idEvaluacion { set; get; }
        
    }
}

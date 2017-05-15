﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class EquipoCelular
    {
        public int idEquipoCelular { set; get; }
        public String modeloCelular { set; get; }
        public int añoFabricacion { set; get; }
        public String nroSerieCelular { set; get; }

        public AdministradorEquipo administradorEquipo { set; get; }
        public int idAdministradorEquipo { set; get; }

    }
}

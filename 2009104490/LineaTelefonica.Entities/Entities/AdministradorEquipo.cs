﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class AdministradorEquipo
    {
        public int idAdministradorEquipo { set; get; }
        public String DNI { set; get; }
        public String nombres { set; get; }
        public String apellidos { set; get; }
        public String correo { set; get; }
        public String telf_contacto { set; get; }

        public EquipoCelular equipoCelular { set; get; }
    }
}
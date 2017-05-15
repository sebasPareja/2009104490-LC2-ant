using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;
namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class TrabajadorConfiguration : EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorConfiguration()
        {

            ToTable("Trabajador");
            HasKey(p => p.idTrabajador);


        }
    }
}

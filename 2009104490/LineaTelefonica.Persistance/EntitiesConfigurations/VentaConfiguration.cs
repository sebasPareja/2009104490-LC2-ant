using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class VentaConfiguration: EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {

            ToTable("Venta");
            HasKey(p => p.idVenta);

            HasRequired(c => c.evaluacion).WithRequiredDependent(p => p.venta);
            HasRequired(c => c.contrato).WithMany(p => p.ventas);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    class ProvinciaConfiguration : EntityTypeConfiguration<Provincia>
    {
        public ProvinciaConfiguration()
        {

            ToTable("Provincia");
            HasKey(p => p.idProvincia);

            HasRequired(c => c.departamento).WithMany(p => p.ListaProvincias);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfiguration()
        {

            ToTable("Distrito");
            HasKey(p => p.idDistrito);

            HasRequired(c => c.provincia).WithMany(p => p.ListDistritos);

        }
    }
}

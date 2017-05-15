using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class DireccionConfiguration :EntityTypeConfiguration<Direccion>
    {
        public DireccionConfiguration()
        {

            ToTable("Direccion");
            HasKey(p => p.idDireccion);

            HasRequired(c => c.ubigeo).WithMany(p => p.ListaDireccion);

        }
    }
}

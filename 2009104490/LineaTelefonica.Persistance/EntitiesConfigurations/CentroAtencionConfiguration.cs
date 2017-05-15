using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfiguration()
        {

            ToTable("CentroAtencion");
            HasKey(p => p.idCentroAtencion);

            HasRequired(c => c.direccion).WithRequiredPrincipal(p => p.centroatencion);

        }
    }
}

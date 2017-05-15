using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    class EquipoCelularConfiguration :EntityTypeConfiguration<EquipoCelular>
    {
        public EquipoCelularConfiguration()
        {

            ToTable("EquipoCelular");
            HasKey(p => p.idEquipoCelular);

            HasRequired(c => c.administradorEquipo).WithRequiredPrincipal(p => p.equipoCelular);
        }
    }
}

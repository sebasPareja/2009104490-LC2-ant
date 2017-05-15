using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class PlanConfiguration : EntityTypeConfiguration<Plan>
    {
        public PlanConfiguration()
        {

            ToTable("Plan");
            HasKey(p => p.idPlan);

        }
    }
}

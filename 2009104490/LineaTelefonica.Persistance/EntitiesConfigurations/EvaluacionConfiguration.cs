using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class EvaluacionConfiguration : EntityTypeConfiguration<Evaluacion>
    {
        public EvaluacionConfiguration()
        {

            ToTable("Evaluacion");
            HasKey(p => p.idEvaluacion);

            HasRequired(c => c.cliente).WithMany(p => p.ListEvaluaciones);
            HasRequired(c => c.trabajador).WithMany(p => p.ListEvaluaciones);

            
        }
    }
}

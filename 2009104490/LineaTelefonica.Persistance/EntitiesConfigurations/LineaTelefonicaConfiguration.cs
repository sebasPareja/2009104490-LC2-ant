using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;

namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class LineaTelefonicaConfiguration : EntityTypeConfiguration<LineaTelefonica.Entities.LineaTelefonica>
    {

        public LineaTelefonicaConfiguration()
        {

            ToTable("LineaTelefonica");
            HasKey(p => p.idLineaTelefonica);

            HasRequired(c => c.administradorLinea).WithRequiredPrincipal(p => p.lineatelefonica);
        }
    }
}

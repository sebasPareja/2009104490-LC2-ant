using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;
namespace LineaTelefonica.Persistance.EntitiesConfigurations
{
    public class UbigeoConfiguration : EntityTypeConfiguration<Ubigeo>
    {

        public UbigeoConfiguration()
        {

            ToTable("Ubigeo");
            HasKey(p => p.idUbigeo);

            HasRequired(c => c.provincia).WithRequiredDependent(p => p.ubigeo);
            HasRequired(c => c.departamento).WithRequiredDependent(p => p.ubigeo);
            HasRequired(c => c.distrito).WithRequiredDependent(p => p.ubigeo);

        }
    }
}

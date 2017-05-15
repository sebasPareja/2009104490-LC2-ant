using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineaTelefonica.Entities;
using LineaTelefonica.Persistance.EntitiesConfigurations;

namespace LineaTelefonica.Persistance
{
    class LineaTelefonicaDbContext : DbContext
    {
        public DbSet<AdministradorEquipo> administradorEquipo { get; set; }
        public DbSet<AdministradorLinea> administradorLinea { get; set; }
        public DbSet<CentroAtencion> centroatencion { get; set; }
        public DbSet<Contrato> contrato { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Departamento> departamento { get; set; }
        public DbSet<Direccion> direccion { get; set; }
        public DbSet<Distrito> distrito { get; set; }
        public DbSet<EquipoCelular> equipocelular { get; set; }
        public DbSet<Evaluacion> evaluacion { get; set; }
        public DbSet<LineaTelefonica.Entities.LineaTelefonica> lineatelefonica { get; set; }
        public DbSet<Plan> plan { get; set; }
        public DbSet<Provincia> provincia { get; set; }
        public DbSet<Trabajador> trabajador { get; set; }
        public DbSet<Ubigeo> ubigeo { get; set; }
        public DbSet<Venta> venta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministradorEquipoConfiguration());
            modelBuilder.Configurations.Add(new AdministradorLineaConfiguration());
            modelBuilder.Configurations.Add(new CentroAtencionConfiguration());
            modelBuilder.Configurations.Add(new ContratoConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            modelBuilder.Configurations.Add(new DireccionConfiguration());
            modelBuilder.Configurations.Add(new DistritoConfiguration());
            modelBuilder.Configurations.Add(new EquipoCelularConfiguration());
            modelBuilder.Configurations.Add(new EvaluacionConfiguration());
            modelBuilder.Configurations.Add(new LineaTelefonicaConfiguration());
            modelBuilder.Configurations.Add(new PlanConfiguration());
            modelBuilder.Configurations.Add(new ProvinciaConfiguration());
            modelBuilder.Configurations.Add(new TrabajadorConfiguration());
            modelBuilder.Configurations.Add(new UbigeoConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());
            base.OnModelCreating(modelBuilder);

        }

    }
}

using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.app.Persistencia.AppRepositorios
{
    public class AppContext: DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> FamiliaDesignados { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<SignoVital> SignoVitales { get; set; }
        public DbSet<SugerenciaCuidado> SugerenciaCuidados { get; set; } 
        public DbSet<HistoriasClinica> HistoriasClinicas { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data source =localhost; Initial Catalog = HospiEnCasaData");
            }
        }           
        public TareasContext(DbContextOptions<AppContext> options) :base(options) { }
 
        
    }
}
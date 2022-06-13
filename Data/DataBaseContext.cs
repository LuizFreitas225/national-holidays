using Microsoft.EntityFrameworkCore;
using nationalHolidays.Model;

namespace nationalHolidays.Data

{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RBOB4GJ\SQLEXPRESS;Initial Catalog=national_holidays;Integrated Security=True");
        }
        public DbSet<Continente>? Continentes { get; set; }
        public DbSet<Feriado>? Feriados { get; set; }
        public DbSet<Localidade>? localidades { get; set; }
        public DbSet<Pais>? Paises { get; set; }
        public DbSet<Regiao>? Regioes { get; set; }

    }
}

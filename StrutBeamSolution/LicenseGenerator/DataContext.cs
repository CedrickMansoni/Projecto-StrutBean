using Microsoft.EntityFrameworkCore;

namespace LicenseGenerator
{
    public class DataContext : DbContext
    {
        public DbSet<CodigoGerado> TabelaCodigo {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={PathDb.GetPath("mycode.db")}");
        }
    }
}

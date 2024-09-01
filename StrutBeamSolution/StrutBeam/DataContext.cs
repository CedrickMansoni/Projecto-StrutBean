using Microsoft.EntityFrameworkCore;
using StrutBeam.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutBeam
{
    public class DataContext : DbContext
    {
        public DbSet<Clients> TabelaUsuario { get; set; }
        public DbSet<Licenses> TabelaLicenca { get; set; }
        public DbSet<CustomerIdentification> TabelaClienteId { get; set; }
        public DbSet<ControlAccess> TabelaControlAccess { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={PathDb.GetPath("mydata.db")}");
        }
    }
}

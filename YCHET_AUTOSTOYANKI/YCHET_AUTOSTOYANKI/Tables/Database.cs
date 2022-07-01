using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCHET_AUTOSTOYANKI.Tables
{

    public class Database : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Autostop> Autostops { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Auto> Autos { get; set; }

        public Database()
        {
            //https://www.npgsql.org/efcore/release-notes/6.0.html?tabs=annotations
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseNpgsql("Host=localhost;" +
                                     "Port=5334;" +
                                     "Database=ychet_autostoyanki;" +
                                     "Username=postgres;" +
                                     "Password=6519;");
        }
    }
}

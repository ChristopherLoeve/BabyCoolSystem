using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestCareService.Models
{
    public class BabyDataDbContext : DbContext
    {
        public DbSet<BabyData> BabyData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(
                    "Server=tcp:school-2-db.database.windows.net,1433;Initial Catalog=school-2-database;Persist Security Info=False;User ID=schooladmin;Password=8JeQM#B2nn9S8S%c!Z*4a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                    );
            }
        }
    }
}

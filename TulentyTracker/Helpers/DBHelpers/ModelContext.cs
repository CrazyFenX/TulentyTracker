using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using TulentyTracker.BuisnesObjects;

namespace TulentyTracker.Helpers
{
    internal class ModelContext : DbContext
    {
        private static ModelContext Instance { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Habbit> Habbits { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        //MemoryCache MemoryCache { get; set; }

        private ModelContext()
        {
        }

        public static ModelContext GetContext()
        {
            if (Instance == null)
                Instance = new ModelContext();
            return Instance;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Кэширование
            //IOptions<MemoryCacheOptions> optionsAccessor = ;
            //optionsBuilder.UseMemoryCache(MemoryCache = new MemoryCache(,));

            //optionsBuilder.UseLazyLoadingProxies();
            string connectionString2 = "Server=(localdb)\\mssqllocaldb;Database=TulentyTracker;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString2);
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TulentyTracker;Trusted_Connection=True;");
        }
    }
}

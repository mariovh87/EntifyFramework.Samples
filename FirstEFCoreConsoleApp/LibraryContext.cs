using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FirstEFCoreConsoleApp.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstEFCoreConsoleApp
{
    public class LibraryContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "FirstEFCoreConsoleApp", "library.db");
            var dbDir = Path.GetDirectoryName(dbPath);
            if (!Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        //    optionsBuilder.UseSqlite($"Data Source={Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "library.db")}");

    }
}

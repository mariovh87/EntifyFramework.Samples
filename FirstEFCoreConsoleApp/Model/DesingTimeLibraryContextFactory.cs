using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FirstEFCoreConsoleApp.Model
{
    public class DesingTimeLibraryContextFactory:IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"LibraryManager","library.db");
            var dbDir = Path.GetDirectoryName(dbPath);
            if (!Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            return new LibraryContext(optionsBuilder.Options);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FirstEFCoreConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace FirstEFCoreConsoleApp
{
    public class LibraryContext: DbContext
    {
        //Table Name is DbSet Property Name
        //Rest of tables named as class name
        public DbSet<BookFile> BookFiles { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<PhisicalLibrary> PhisicalLibraries { get; set; }
        public DbSet<ProliphicAuthor> ProliphicAuthors { get; set; }

        public IQueryable<ProliphicAuthor> GetProliphicAuthors(int rows) =>
            FromExpression(() => GetProliphicAuthors(rows));

        public LibraryContext()
        {
        }
        public LibraryContext(DbContextOptions<LibraryContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var phisicalLibrary = modelBuilder.Entity<PhisicalLibrary>();
            phisicalLibrary
                .Ignore(p=>p.LoadeDate)
                .Property(p => p.Name).HasColumnName("LibraryName")
                .HasColumnType("nvarchar(200)");
            phisicalLibrary.ToTable("PhisicalLibraries", t =>
                    t.ExcludeFromMigrations()
                        .HasComment("Tabla para almacenar las bibliotecas físicas"));

            //Create View in Db
            modelBuilder.Entity<RatedBook>()
                .ToView("MostHighlyRatedBooks", schema: "dbo")
                .HasNoKey();

            //Create DbFunction
            modelBuilder.HasDbFunction(typeof(LibraryContext).GetMethod(nameof(GetProliphicAuthors),
                new[] { typeof(int) }))
                .HasName("MostProliphicAuthors")
                .HasSchema("dbo");

            base.OnModelCreating(modelBuilder);
        }

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

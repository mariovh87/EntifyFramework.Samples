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
    /// <summary>
    /// Collation Latin CI AS. Case Insensitive. Accent Sensitive
    /// </summary>
    public class LibraryContext: DbContext
    {
        //Table Name is DbSet Property Name
        //Rest of tables named as class name
        public DbSet<BookFile> BookFiles { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<Author?> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<PhisicalLibrary> PhisicalLibraries { get; set; }
        public DbSet<ProliphicAuthor> ProliphicAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }

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
            //var authors = modelBuilder.Entity<Author>();
            //authors.HasMany(p=>p.Books)
            //    .WithOne(b=>b.Author)
            //    .HasPrincipalKey(p => p.Name);

            var authors = modelBuilder.Entity<Author>();

            authors.HasQueryFilter(a => !a.IsDeleted);

            authors.Property(p=>p.LoadeDate)
                .HasDefaultValueSql("getutcdate()");
            modelBuilder.Entity<Author>();
            authors.Property(p => p.LastName)
                .HasDefaultValue("Apellido1");

            modelBuilder.Entity<Author>();
            authors.Property(p => p.DisplayName)
                .HasComputedColumnSql("Name + ' ' + LastName", stored:true);

            //If model has shadow properties, use anonym object
            //Use for static data that never changes, example, Country table. If is modified or removed, migrations could fail
            authors.HasData(new[]
            {
                new Author { AuthorId = 1, Name = "Stephen", LastName = "King", AuthorUrl = "stephenking" },
                new Author { AuthorId = 2, Name = "Isaac", LastName = "Asimov", AuthorUrl = "asimov" }
            });

            var phisicalLibrary = modelBuilder.Entity<PhisicalLibrary>();
            phisicalLibrary
                .HasKey(p => p.PhisicalLibraryId)
                .HasName("PK_PhisicalLibraries");

            phisicalLibrary
                .Ignore(p=>p.LoadeDate)
                .Property(p => p.Name).HasColumnName("LibraryName")
                .IsRequired()
                .UseCollation("SQL_Latin1_General_CP1_CI_AI")
                .HasComment("Columna inventada para pruebas")
                .HasColumnType("nvarchar(200)");

            phisicalLibrary
                .Property(p => p.CompanyName).HasMaxLength(100);

            phisicalLibrary.HasIndex(p =>p.CompanyName).IsUnique(true);

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

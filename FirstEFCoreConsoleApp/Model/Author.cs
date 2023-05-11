using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstEFCoreConsoleApp.Model
{
    [Index(nameof(Name), nameof(LastName))]
    public partial class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Column("AuthorName", TypeName = "nvarchar(200)")]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Comment("Primer apellido en España. Surname en otros paises")]
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        /// <summary>
        /// Nullable reference enabled. Explicit nullable with ?
        /// </summary>
        public string? Biography { get; set; }
        public List<Book> Books { get; set; }
        [NotMapped]
        public DateTime LoadeDate { get; set; }
        /// <summary>
        /// CountryId hidden column generated in DB
        /// </summary>
        public Country Country { get; set; }
        public string AuthorUrl { get; set; }

        public bool IsDeleted { get; set; }
    }
}

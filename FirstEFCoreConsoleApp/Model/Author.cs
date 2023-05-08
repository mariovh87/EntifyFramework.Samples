using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public partial class Author
    {
        public int AuthorId { get; set; }
        [Column("AuthorName", TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; }
        [NotMapped]
        public DateTime LoadeDate { get; set; }
    }
}

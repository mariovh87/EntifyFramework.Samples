using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public partial class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; }
    }
}

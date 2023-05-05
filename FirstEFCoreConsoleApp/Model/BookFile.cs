using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public class BookFile
    {
        public int BookFileId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string InternalFilePath { get; set; }
    }
}

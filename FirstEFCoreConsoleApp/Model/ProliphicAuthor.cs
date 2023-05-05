using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public class ProliphicAuthor
    {
        public int ProliphicAuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BookCount { get; set; }
    }
}

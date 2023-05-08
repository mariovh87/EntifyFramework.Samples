using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public class PhisicalLibrary
    {
        public int PhisicalLibraryId { get; set; }
        
        public string Name { get; set; }
        public DateTime LoadeDate { get; set; }
    }
}

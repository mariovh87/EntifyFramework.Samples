using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    public class AuditEntry
    {
        public int AuditEntryId { get; set; }
        public DateTime Date { get; set; }
        public string Operation { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}

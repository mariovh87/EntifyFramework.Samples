using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFCoreConsoleApp.Model
{
    [Table("Countries")]
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<AuditEntry> AuditEntries { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weaver.Data.Models
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Db class")]
    public class JournalTemplate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<JournalGrid> RootComponents { get; set; } = new List<JournalGrid>();
        public List<JournalTemplate> Journals { get; set; } = new List<JournalTemplate>();
        public AppUser Owner { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Weaver.Data.Models
{
    public class JournalTemplate
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public JournalGrid RootComponent { get; set; }
        public List<JournalTemplate> Journals { get; set; }
        public AppUser Owner { get; set; }
    }
}

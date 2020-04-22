using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Weaver.Data.Models
{
    public class AppUser : IdentityUser
    {
        public virtual List<JournalTemplate> JournalTemplates { get; set; }
    }
}

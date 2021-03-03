using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Le_Messageur.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUser> following { get; set; }
    }
}

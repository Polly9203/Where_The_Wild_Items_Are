using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Register { get; set; }
        public DateTime Auth { get; set; }
        //public List<Collection> Collection  { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Where_The_Wild_Items_Are.Models
{
    public class Table
    {
        public String ID { get; set; }
        public String Email { get; set; }
        public DateTime Auth { get; set; }
        public DateTime Register { get; set; }
        public bool Status { get; set; }
        public String Role { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.entities
{
    public class Membership : entitybase
    {
        public string MembershipType { get; set; }
        public int Duration { get; set; } // In months
        public decimal Price { get; set; }


    }
}

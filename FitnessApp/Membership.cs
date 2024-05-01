using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class Membership : Entitybase
    {
        public string MembershipType { get; set; }
        public int Duration { get; set; } // In months
        public decimal Price { get; set; }


    }
}


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FitnessApp
{
    public class Members : Entitybase
    {
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public DateTime DOB { get; set; }
        public char Gender { get; set; }
    }
}
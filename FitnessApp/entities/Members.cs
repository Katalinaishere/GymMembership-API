using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.entities
{
    public class Members: entitybase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }   


        public DateTime DOB { get; set; }
        public char Gender { get; set; }

        internal class Test
        {
            internal class Members
            {
            }
        }
    }
}

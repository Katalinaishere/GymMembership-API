using System.Collections.Generic;
using Membership.ProAPI.Models;

namespace Membership.ProAPI.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly List<Member> _memberships; // Assuming you have a list of memberships

        public MembershipService()
        {
            // Initialize the list of memberships (for demonstration purposes)
            _memberships = new List<Member>
            {
                new Member { Id = 1, FullName = "Member One", DOB = DateTime.Now.AddYears(-20) },
                new Member { Id = 2, FullName = "Member Two", DOB = DateTime.Now.AddYears(-25) }
            };
        }

        public IEnumerable<Member> GetMemberships()
        {
            return _memberships;
        }
    }
}

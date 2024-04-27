using Membership.ProAPI.Models;

namespace Membership.ProAPI.Services
{
        public interface IMembershipService
        {
            IEnumerable<Member> GetMemberships(); // Define a method to retrieve memberships
        }
    }


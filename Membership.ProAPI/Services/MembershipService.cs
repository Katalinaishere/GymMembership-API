using Membership.Data;
using Membership.ProAPI.Dto;
using Membership.ProAPI.Models;

namespace Membership.ProAPI.Services
{

    public class MembershipService : IMembershipService

    {

        private AppDbContext _context;
        private readonly List<MembershipService> _memberships; // Assuming in-memory storage

        public int Id { get; private set; }

       /* public MembershipService(AppDbContext context)
        {
            // Initialize memberships (can be replaced with database calls)
            _memberships = new List<PutMembershipDto>
            {
                new Membership { Id = 1, Type = "Basic", Duration = 30, Price = 50.00m },
                new Membership { Id = 2, Type = "Premium", Duration = 60, Price = 100.00m }
            };
        }*/

        public IEnumerable<PutMembershipDto> GetAllMemberships()
        {
            return (IEnumerable<PutMembershipDto>)_memberships;
        }

        public List<MembershipService> Get_memberships()
        {
            return _memberships;
        }

        public void CreateMembership(PutMembershipDto Membership, List<MembershipService> _memberships)
        {
            
        }

        public void UpdateMembership(int id, MembershipService updatedMembership)
        {
            var membershipIndex = _memberships.FindIndex(m => m.Id == id);
            if (membershipIndex != -1)
            {
                _memberships[membershipIndex] = updatedMembership;
            }
            else
            {
                throw new InvalidOperationException("Membership not found.");
            }
        }

        public void DeleteMembership(int id)
        {
            var membership = _memberships.Find(m => m.Id == id);
            if (membership != null)
            {
                _memberships.Remove(membership);
            }
            else
            {
                throw new InvalidOperationException("Membership not found.");
            }
        }

        public void CreateMembership(PutMembershipDto membership)
        {
            throw new NotImplementedException();
        }

        public void UpdateMembership(int id, PutMembershipDto updatedMembership)
        {
            throw new NotImplementedException();
        }

        public object GetMemberships()
        {
            throw new NotImplementedException();
        }

        public PutMembershipDto GetMembershipById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
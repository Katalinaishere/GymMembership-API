using Membership.ProAPI;
using Membership.ProAPI.Dto;
using Membership.ProAPI.Models;

namespace Membership.ProAPI.Services
{

    public class MembershipService : IMembershipService

    {

        private AppDbContext _context;
        private readonly List<MembershipService> _memberships; // Assuming in-memory storage

        public int Id { get; private set; }

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

        public object SearchMemberships(string membershipType, int? minDuration, int? maxDuration, decimal? minPrice, decimal? maxPrice)
        {
            throw new NotImplementedException();
        }

        public void CreateMembership(Models.Membership membership)
        {
            throw new NotImplementedException();
        }
    }
}
using Membership.ProAPI.Dto;

namespace Membership.ProAPI.Services
{
    public interface IMembershipService
    {
        PutMembershipDto GetMembershipById(int id);
        IEnumerable<PutMembershipDto> GetAllMemberships();
        void CreateMembership(PutMembershipDto membership);
        void UpdateMembership(int id, PutMembershipDto updatedMembership);
        void DeleteMembership(int id);
        object GetMemberships();
        object SearchMemberships(string membershipType, int? minDuration, int? maxDuration, decimal? minPrice, decimal? maxPrice);
        void CreateMembership(Models.Membership membership);
    }
}


using Membership.ProAPI.Dto;
namespace Membership.ProAPI.Services
{
    public interface IMembersService
    {
        List<Models.Member> GetMembers();
        Models.Member GetMemberById(int id);
        Models.Member AddMember(PostMemberDto student);
        Models.Member UpdateStudent(PutMemberDto memberData, int id);
        void DeleteMember(int id);
    }
}

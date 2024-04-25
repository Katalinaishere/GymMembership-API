
namespace GymMembership.API.Models
{
    public class Member
    {
        public int Id { get; internal set; }
        public string FullName { get; internal set; }
        public DateTime DOB { get; internal set; }

        internal class API
        {
        }
    }
}

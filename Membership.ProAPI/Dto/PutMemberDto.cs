namespace GymMembership.API.Dto
{
    public class PutMemberDto
    {

        public string FullName { get; set; }
        public DateTime DOB { get; set; } = DateTime.Now;
    }
}

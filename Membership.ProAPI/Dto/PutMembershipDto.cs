namespace Membership.ProAPI.Dto
{
    public class PutMembershipDto
    {

      public string Id { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; }
        public object Membershiptype { get; internal set; }
        public object Duration { get; internal set; }
        public object Price { get; internal set; }
    }
}

namespace Membership.ProAPI.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string MembershipType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
    }
}


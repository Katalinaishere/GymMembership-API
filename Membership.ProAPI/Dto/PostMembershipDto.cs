namespace Membership.ProAPI.Dto
{
    public class PostMembershipDto
    {
        public string Membershiptype { get; set; }
        public int DurationInMonths { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }   
        }
    }

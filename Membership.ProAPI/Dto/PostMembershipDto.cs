namespace Membership.ProAPI.Dto
{
    public class PostMembershipDto
    {
        public string Membershiptype { get; set; }
        public int DurationInMonths { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Nullable if membership is ongoing

        // Additional properties as needed for contact information, payment details, etc.
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }   
        }
    }

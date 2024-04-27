using Microsoft.AspNetCore.Mvc;
using Membership.ProAPI.Services;

namespace Membership.ProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipService _service;

        public MembershipController(IMembershipService service)
        {
            _service = service;
        }

        // GET: api/Memberships/All
        [HttpGet("All")]
        public IActionResult GetMemberships()
        {
            var memberships = _service.GetMemberships();
            return Ok(memberships);
        }

        // GET: api/Memberships/GetById/{id}
        [HttpGet("GetById/{id}")]
        public IActionResult GetMembershipById(int id)
        {
            var memberships = _service.GetMemberships();
            var membership = memberships.FirstOrDefault(m => m.Id == id);

            if (membership == null)
            {
                return NotFound();
            }

            return Ok(membership);
        }
    }
}



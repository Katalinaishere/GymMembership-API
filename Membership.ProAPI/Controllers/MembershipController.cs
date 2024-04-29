using Microsoft.AspNetCore.Mvc;
using Membership.ProAPI.Services;
using Membership.ProAPI.Models;
using Membership.ProAPI.Dto;
using System.Linq;

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

        // GET: api/Membership/All
        [HttpGet("All")]
        public IActionResult GetMemberships()
        {
            var memberships = _service.GetMemberships();
            return Ok(memberships);
        }

        // GET: api/Membership/GetById/{id}
        [HttpGet("GetById/{id}")]
        public IActionResult GetMembershipById(int id)
        {
            var membership = _service.GetMembershipById(id);

            if (membership == null)
            {
                return NotFound();
            }

            return Ok(membership);
        }

        // PUT: api/Membership/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PutMembershipDto membershipDto)
        {
            var membership = _service.GetMembershipById(id);
            if (membership == null)
            {
                return NotFound();
            }

            // Update membership properties
            membership.Membershiptype = membershipDto.Membershiptype;
            membership.Duration = membershipDto.Duration;
            membership.Price = membershipDto.Price;

            _service.UpdateMembership(id, membership);
            return NoContent();
        }

        // DELETE: api/Membership/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var membership = _service.GetMembershipById(id);
            if (membership == null)
            {
                return NotFound();
            }

            _service.DeleteMembership(id);
            return NoContent();
        }
    }
}

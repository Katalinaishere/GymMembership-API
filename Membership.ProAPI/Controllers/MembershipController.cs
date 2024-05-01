using Microsoft.AspNetCore.Mvc;
using Membership.ProAPI.Services;
using Membership.ProAPI.Dto;
using MembershipModel = Membership.ProAPI.Models.Membership;

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

        [HttpPost]
        public IActionResult CreateMembership([FromBody] PostMembershipDto membershipDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var membership = new MembershipModel
                {
                    Membershiptype = membershipDto.Membershiptype,
                    Duration = membershipDto.DurationInMonths,
                    Price = membershipDto.Price,
                    StartDate = membershipDto.StartDate,
                    EndDate = (DateTime)membershipDto.EndDate
                };

                _service.CreateMembership(membership);

                return CreatedAtAction(nameof(GetMembership), new { id = membership.Id }, membership);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        private object GetMembership()
        {
            throw new NotImplementedException();
        }

        [HttpGet("All")]
        public IActionResult GetMemberships([FromQuery] int? minPrice, [FromQuery] int? maxPrice, [FromQuery] int? minDuration, [FromQuery] int? maxDuration)
        {
            var memberships = _service.GetAllMemberships();

            // Apply filters
            if (minPrice.HasValue)
            {
                memberships = memberships.Where(m => (int)m.Price >= minPrice);
            }
            if (maxPrice.HasValue)
            {
                memberships = memberships.Where(m => (int)m.Price <= maxPrice);
            }
            if (minDuration.HasValue)
            {
                memberships = memberships.Where(m => (int)m.Duration >= minDuration);
            }
            if (maxDuration.HasValue)
            {
                memberships = memberships.Where(m => (int)m.Duration <= maxDuration);
            }

            return Ok(memberships);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var membership = _service.GetMembershipById(id);
                if (membership == null)
                {
                    return NotFound();
                }
                return Ok(membership);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("search")]
        public IActionResult SearchMemberships([FromQuery] string membershipType, [FromQuery] int? minDuration, [FromQuery] int? maxDuration, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            try
            {
                var memberships = _service.SearchMemberships(membershipType, minDuration, maxDuration, minPrice, maxPrice);
                return Ok(memberships);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PutMembershipDto membershipDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var membership = _service.GetMembershipById(id);
                if (membership == null)
                {
                    return NotFound();
                }

                membership.Membershiptype = membershipDto.Membershiptype;
                membership.Duration = membershipDto.Duration;
                membership.Price = membershipDto.Price;

                _service.UpdateMembership(id, membership);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var membership = _service.GetMembershipById(id);
                if (membership == null)
                {
                    return NotFound();
                }

                _service.DeleteMembership(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}

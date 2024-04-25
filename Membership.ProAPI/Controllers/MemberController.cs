using GymMembership.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GymMembership.API.Dto;

namespace GymMembership.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetMembers()
        {
            
            var allMembers = new List<GymMembership.API.Models.Member>()
            {
                new GymMembership.API.Models.Member()
                {
                    Id = 1,
                    FullName = "member one",
                    DOB = DateTime.Now.AddYears(-20)
                },
                new GymMembership.API.Models.Member()
                {
                    Id = 2,
                    FullName = "member two",
                    DOB = DateTime.Now.AddYears(-20)
                },
            };

            return Ok(allMembers);
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetMemberById(int id)
        {
            var newMember = new Models.Member()
            {
                Id = 1,
                FullName = "member one",
                DOB = DateTime.Now.AddYears(-20)
            };

            return Ok(newMember);
        }



    }
}

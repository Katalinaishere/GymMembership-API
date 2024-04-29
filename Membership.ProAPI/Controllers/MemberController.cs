using System;
using System.Collections.Generic;
using Membership.ProAPI.Models;
using Membership.Data;
using Microsoft.AspNetCore.Mvc;

namespace GymMembership.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MembersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Members/All
        [HttpGet("All")]
        public IActionResult GetMembers()
        {
            var allMembers = new List<Member>
            {
                new Member
                {
                    Id = 1,
                    FullName = "member one",
                    DOB = DateTime.Now.AddYears(-20)
                },
                new Member
                {
                    Id = 2,
                    FullName = "member two",
                    DOB = DateTime.Now.AddYears(-20)
                }
            };

            return Ok(allMembers);
        }

        // GET: api/Members/GetById/{id}
        [HttpGet("GetById/{id}")]
        public IActionResult GetMemberById(int id)
        {
            var newMember = new Member
            {
                Id = 1,
                FullName = "member one",
                DOB = DateTime.Now.AddYears(-20)
            };

            return Ok(newMember);
        }
    }

}

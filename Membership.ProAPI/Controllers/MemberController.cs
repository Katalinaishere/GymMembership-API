using System;
using System.Collections.Generic;
using Membership.ProAPI.Dto;
using Membership.ProAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FitnessApp.Data;
using Membership.ProAPI.Models;

namespace Membership.ProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext _service;

        public MembersController(AppDbContext service)
        {
            _service = service;
        }

        // GET: api/Members/All
        [HttpGet("All")]
        public IActionResult GetMembers()
        {
            var allMembers = _service.GetMembers();

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

        // POST: api/Members/AddNewMember
        [HttpPost("AddNewMember")]
        public IActionResult AddNewMember([FromBody] PostMemberDto payload)
        {
            var newMember = _service.AddMember(payload);

            return Ok(newMember);
        }
    }
}

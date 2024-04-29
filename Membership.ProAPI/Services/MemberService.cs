using System;
using System.Collections.Generic;
using System.Linq;
using Membership.Data;
using Membership.ProAPI.Dto;
using Membership.ProAPI.Models;

namespace Membership.ProAPI.Services
{
    public class MemberService:IMembersService
    {
        private readonly AppDbContext _context;

        public MemberService(AppDbContext context)
        {
            _context = context;
        }

        // Method to retrieve all members
        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }

        // Method to retrieve a member by ID
        public Member GetMemberById(int id)
        {
            return _context.Members.FirstOrDefault(m => m.Id == id);
        }

        // Method to add a new member
        public void AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        // Method to update an existing member
        public void UpdateMember(Member member)
        {
            _context.Members.Update(member);
            _context.SaveChanges();
        }

        // Method to delete a member by ID
        public void DeleteMember(int id)
        {
            var memberToDelete = _context.Members.FirstOrDefault(m => m.Id == id);
            if (memberToDelete != null)
            {
                _context.Members.Remove(memberToDelete);
                _context.SaveChanges();
            }
        }

        public Member AddMember(PostMemberDto student)
        {
            throw new NotImplementedException();
        }

        public Member UpdateStudent(PutMemberDto memberData, int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // localhost:5001/api/members
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IReadOnlyList<AppUser>> GetMembers()
        {
            var members = context.Users.ToList();
            return (members);
        }

        [HttpGet("{id}")] // localhost:5001/api/members/{id}
        public ActionResult<AppUser> GetMember(string id)
        {
            var member = context.Users.Find(id);
            if (member == null) return NotFound();
            return member;
        }
        // public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        // {
        //     var members = await context.Members.ToListAsync();
        //     return Ok(members);
        // }
    }
}
using back.Data;
using back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using back.Data;
using back.Models;

namespace back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        private readonly backContext _context;
        public Test(backContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<User>> GetLast()
        {
            var users = new List<User>();
            users = await _context.Users.ToListAsync();
            return  users.Last();
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetFirst()
        {
            var users = new List<User>();
            users = await _context.Users.ToListAsync();
            return users.First();
        }


    }
}

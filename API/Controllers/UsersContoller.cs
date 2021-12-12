using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersContoller : ControllerBase
    {
        public DataContext _context;
        public UsersContoller(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           return await _context.User.ToListAsync();
           
        }

//api/users/3 ---> will give te parameter for the id 3 beacuse of the http
  [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)//get from the rout 
        {

         return await _context.User.FindAsync(id);
        }

    }
}
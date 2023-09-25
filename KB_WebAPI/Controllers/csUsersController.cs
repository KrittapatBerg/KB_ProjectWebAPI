using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KB_WebAPI.Models;
using KB_WebAPI.databaseContext;

namespace KB_WebAPI.Controllers
{
    [Route("api/[controller]")]     //this one c# generate it for me 
    [ApiController]
    public class csUsersController : ControllerBase
    {
        private readonly DataContext _context;

        public csUsersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/csUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<csUser>>> GetUsers()
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            return await _context.Users.ToListAsync();
        }

        // GET: api/csUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<csUser>> GetcsUser(Guid id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var csUser = await _context.Users.FindAsync(id);

            if (csUser == null)
            {
                return NotFound();
            }

            return csUser;
        }

        // PUT: api/csUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutcsUser(Guid id, csUser csUser)
        {
            if (id != csUser.UserId)
            {
                return BadRequest();
            }

            _context.Entry(csUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!csUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/csUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<csUser>> PostcsUser(csUser csUser)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'sqlContext.Users'  is null.");
          }
            _context.Users.Add(csUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetcsUser", new { id = csUser.UserId }, csUser);
        }

        // DELETE: api/csUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletecsUser(Guid id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var csUser = await _context.Users.FindAsync(id);
            if (csUser == null)
            {
                return NotFound();
            }

            _context.Users.Remove(csUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool csUserExists(Guid id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}

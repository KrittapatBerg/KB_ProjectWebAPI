using KB_WebAPI.databaseContext;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KB_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionController : ControllerBase
    {
        private readonly IAttraction _attractionRepo;
        private readonly DataContext _context;
        public AttractionController(IAttraction attractionRepo, DataContext context)
        {
            _attractionRepo = attractionRepo;
            _context = context;
        }

        // GET: api/Attractions 
        //[HttpGet]
        /*public async Task<ActionResult<IEnumerable<csAttraction>>> GetAttractions()
        {
            if (_context.Attractions == null)
            {
                return NotFound();
            }
            return await _context.Attractions.ToListAsync(); 
        }*/
        [HttpGet]
        //[ProducesResponseType(200, typeof(IEnumerable<csAttraction>))]
        public IActionResult GetAttractions()
        {
            var attraction = _attractionRepo.getAttractions();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
        
            return Ok(attraction);
        }

        //GET : api/AttractionId
        [HttpGet("{id}")]
        public async Task<ActionResult<csAttraction>> GetAttractionId(Guid id)
        {
            if(_context.Attractions == null)
            {
                return NotFound();
            }
            var attraction = await _context.Attractions.FindAsync(id);

            if (attraction == null)
            {
                return NotFound();
            }
            return attraction;
        }

        //PUT : api/Attraction
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAttraction(Guid id, csAttraction attraction){}
    }
}

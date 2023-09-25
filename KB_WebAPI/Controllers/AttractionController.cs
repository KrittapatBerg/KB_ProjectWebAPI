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
        [HttpGet("{attractionId}")]
        [ProducesResponseType(typeof(csAttraction), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<csAttraction>> getAttractionById(Guid id)
        {
            if(!_attractionRepo.attractionExists(id))
                return NotFound();

            var attraction = _attractionRepo.getAttractionById(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
           
            return Ok(attraction);
        }

        [HttpGet("{attractionId}/ rating")]
        [ProducesResponseType(typeof(decimal), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> getAttractionRating(Guid ratingId)
        {
            if(!_attractionRepo.attractionExists(ratingId))
                return NotFound();

            var rating = _attractionRepo.getAttractionRating(ratingId);

            if (!ModelState.IsValid)
                return BadRequest(); 
            return Ok(rating);
        }

        //[HttpGet("{category}")]
    }
}

using AutoMapper;
using KB_WebAPI.databaseContext;
using KB_WebAPI.DTO;
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
        private readonly IMapper _mapper;
        public AttractionController(IAttraction attractionRepo, IMapper mapper)
        {
            _attractionRepo = attractionRepo;
            _mapper = mapper;
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
        [ProducesResponseType(200, Type = typeof(IEnumerable<csAttraction>))]
        [ProducesResponseType(400)]
        public IActionResult GetAttractions()
        {
            var attractions = _mapper.Map<List<AttractionDto>>(_attractionRepo.GetAttractions());
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
        
            return Ok(attractions);
        }

        //GET : api/AttractionId
        [HttpGet("{attractionId}")]
        [ProducesResponseType(typeof(csAttraction), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<csAttraction>> getAttractionById(Guid id)
        {
            if(!_attractionRepo.AttractionExists(id))
                return NotFound();

            var attraction = _mapper.Map<csAttraction>(_attractionRepo.GetAttractionById(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
           
            return Ok(attraction);
        }

        [HttpGet("{attractionId}/ rating")]
        [ProducesResponseType(typeof(decimal), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> getAttractionRating(Guid ratingId)
        {
            if(!_attractionRepo.AttractionExists(ratingId))
                return NotFound();

            var rating = _attractionRepo.GetAttractionRating(ratingId);

            if (!ModelState.IsValid)
                return BadRequest(); 
            return Ok(rating);
        }

        [HttpGet("{category}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetAttractionByCategory(string categorii)
        {
            var category = _mapper.Map<List<AttractionDto>>(_attractionRepo.GetAttractionByCategory(categorii));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }
    }
}

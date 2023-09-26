using AutoMapper;
using KB_WebAPI.DTO;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KB_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRating _ratingRepo;
        private readonly IMapper _mapper;
        public RatingController(IRating ratingRepo, IMapper mapper)
        {
            _ratingRepo = ratingRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<csRating>))]
        [ProducesResponseType(400)]
        public IActionResult GetRatings()
        {
            var ratings = _mapper.Map<List<RatingDto>>(_ratingRepo.GetRatings());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ratings);
        }

        [HttpGet("{ratingId}")]
        [ProducesResponseType(typeof(csRating), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<csRating>> GetRatingById(Guid id)
        {
            if (!_ratingRepo.RatingExists(id))
                return NotFound();

            var rating = _mapper.Map<csRating>(_ratingRepo.GetRatingById(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(rating);
        }

        [HttpGet("{attraction}/rating")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetRatingByAttraction(string attraction)
        {
            var ratingByAtt = _mapper.Map<List<RatingDto>>(_ratingRepo.GetRatingByAttraction(attraction));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ratingByAtt);
        }

        [HttpGet("{rating}/user")]
        [ProducesResponseType(typeof(csRating), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetRatingByUser(Guid userId)
        {
            var ratingUser = _mapper.Map<List<RatingDto>>(_ratingRepo.GetRatingByUser(userId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ratingUser);
        }
    }
}

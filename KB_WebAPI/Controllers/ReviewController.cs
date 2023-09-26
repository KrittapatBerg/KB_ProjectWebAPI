using AutoMapper;
using KB_WebAPI.databaseContext;
using KB_WebAPI.DTO;
using KB_WebAPI.Interfaces;
using KB_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KB_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReview _reviewRepo;
        private readonly IMapper _mapper;
        public ReviewController(IReview reviewRepo, IMapper mapper)
        {
            _reviewRepo = reviewRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<csReview>))]
        [ProducesResponseType(400)]
        public IActionResult GetReviews()
        {
            var reviews = _mapper.Map<List<ReviewDto>>(_reviewRepo.GetReviews());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(reviews);
        }

        [HttpGet("{reviewId}")]
        [ProducesResponseType(typeof(csReview), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<csReview>> GetReview(Guid id)
        {
            if (!_reviewRepo.ReviewExists(id))
                return NotFound();

            var review = _mapper.Map<ReviewDto>(_reviewRepo.GetReview(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(review);
        }

        [HttpGet("{review}/user")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetReviewByUser(Guid userid)
        {
            var reviewByUser = _mapper.Map<List<ReviewDto>>(_reviewRepo.GetReviewByUser(userid));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(reviewByUser); 
        }

        [HttpGet("{review}/attraction")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetReviewByAttraction(Guid attractionid)
        {
            var attractRe = _mapper.Map<List<ReviewDto>>(_reviewRepo.GetReviewByAttraction(attractionid));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(attractRe); 
        }
    }
}

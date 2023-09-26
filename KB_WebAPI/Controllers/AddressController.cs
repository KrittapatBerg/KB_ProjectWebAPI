using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KB_WebAPI.Models;
using KB_WebAPI.databaseContext;
using Microsoft.EntityFrameworkCore;
using KB_WebAPI.Interfaces;
using AutoMapper;
using KB_WebAPI.DTO;

namespace KB_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/action")]
    public class AddressController : ControllerBase
    {
        private readonly IAddress _addressRepo;
        private readonly IMapper _mapper;
        public AddressController(IAddress addressRepo, IMapper mapper)
        {
            _addressRepo = addressRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<csAddress>))]
        [ProducesResponseType(400)]
        public IActionResult GetAddresses()
        {
            var addresses = _mapper.Map<List<AddressDto>>(_addressRepo.GetAddresses());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(addresses); 
        }

        [HttpGet("{addressId}")]
        [ProducesResponseType(typeof(csAddress), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<csAddress>> GetAddress(Guid id)
        {
            if (!_addressRepo.AddressExists(id))
                return NotFound();

            var address = _mapper.Map<AddressDto>(_addressRepo.GetAddress(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(address);
        }
        /*
        [HttpGet]
        [ActionName("Seed")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(400, Type = typeof(string))]
        public async Task<IActionResult> Seed(string address)
        {
            
            try
            {
                    var sGen = new SeedGenerator();
                    var home = new csAddress().Seed(sGen);
                    var attraction = new csAttraction().Seed(sGen);

                    //db.Address.Add(home);
                    //db.Attraction.Add(attraction);
                    //db.SaveChanges();

                    return Ok("Seeded");
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}

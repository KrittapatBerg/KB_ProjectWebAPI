using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using KB_WebAPI.Models;
using KB_WebAPI.databaseContext;
using Microsoft.EntityFrameworkCore;


namespace KB_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/action")]
    public class AddressController : ControllerBase
    {
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

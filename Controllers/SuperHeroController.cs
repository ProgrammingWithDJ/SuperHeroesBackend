using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesBackend.Models;

namespace SuperHeroesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
        {
            return new List<SuperHero> { 
                
                new SuperHero {
                       Name ="Spierman",
                       FirstName ="Peter",
                       LastName ="Parker",
                       Place ="Mumbai"
                           }
            
            };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TestAPI.Models.Domain;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RegionController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name ="Saigon",
                    Code = "SG",
                    Area =  121212,
                    Lat = -12212,
                    Long = 333332,
                    Population = 21323131
                },

                new Region
                {
                    Id = Guid.NewGuid(),
                    Name ="Ha Noi",
                    Code = "HN",
                    Area =  121212,
                    Lat = -12212,
                    Long = 333332,
                    Population = 21323131
                }


            };

            return Ok(regions);
        }
       
    }
}

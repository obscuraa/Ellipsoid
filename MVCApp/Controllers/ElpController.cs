using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ElpController : Controller
    {
        [HttpGet] // elp?pageSize=10&pageNumber=1
        public async Task<IActionResult> GetListAsync([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            return Ok(pageSize + " " + pageNumber);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] EllipsoidViewModel ellipsoid)
        {
            return Ok(ellipsoid);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] EllipsoidViewModel ellipsoid)
        {
            return Ok(ellipsoid);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromBody] int id)
        {
            return Ok(id);
        }
    }
}

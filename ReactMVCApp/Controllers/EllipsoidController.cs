using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactMVCApp.Models;

namespace ReactMVCApp.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class EllipsoidController : Controller
    {
        [HttpGet] // ellipsoid?pageSize=10&pageNumber=1
        public async Task<IActionResult> GetListAsync([FromQuery] int pageSize,[FromQuery] int pageNumber)
        {
            return Ok(pageSize + " " + pageNumber);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] Guid id)
        {
            return Ok(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] EllipsoidModel ellipsoid)
        {
            return Ok(ellipsoid);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] EllipsoidModel ellipsoid)
        {
            return Ok(ellipsoid);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromBody] Guid id)
        {
            return Ok(id);
        }
    }
}

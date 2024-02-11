using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainLogicController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string inputLine, int sortOption)
        {
            return Ok(inputLine);
        }
    }
}

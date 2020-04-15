using Microsoft.AspNetCore.Mvc;

namespace OnlineParser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParserController : ControllerBase
    {
        private readonly ParserService _service;

        public ParserController(ParserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string url)
        {
            return BadRequest();
        }
    }
}

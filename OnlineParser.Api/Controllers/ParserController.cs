using Microsoft.AspNetCore.Mvc;

namespace OnlineParser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParserController : ControllerBase
    {
        private readonly IParserService _service;

        public ParserController(IParserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get(string url)
        {
            var content = _service.Parse(url);
            if (string.IsNullOrEmpty(content))
            {
                return BadRequest();
            }
            return Ok(content);
        }
    }
}

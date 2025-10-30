using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestMyApp5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRequestUrlsCount() {
        
        return Ok();
        }
    }
}

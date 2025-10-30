using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestMyApp5.Controllers
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Getusers()
        {
            List<string> fullNames = [ "mamadi", "Zoraghi", "Moradi" ];
            return Ok(fullNames);
        }
    }
}

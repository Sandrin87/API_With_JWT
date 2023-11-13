using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(string request)
        {


            return Ok();
        }
    }
}

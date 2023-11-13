using JwtApi.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace JwtApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HealthCheckController : Controller
    {
        IConfiguration _configuration;
        ITokenService _tokenService;

        public HealthCheckController(IConfiguration configuration, ITokenService tokenService)
        {
            _configuration = configuration;            
            _tokenService = tokenService;
        }

        [HttpGet]
        public IActionResult HealthcheckAuthorization()
        {
            var response = StatusCode(200);
            var authorized = false;

            //if you are not authorized then, return unauthorized
            if (authorized)
                response = StatusCode(400);

            return response;
        }

        [HttpGet]
        public IActionResult Healthcheck()
        {
            return StatusCode(200);
        }
    }
}

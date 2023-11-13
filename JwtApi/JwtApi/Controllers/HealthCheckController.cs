using JwtApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : Controller
    {
        IConfiguration _configuration;

        public HealthCheckController(IConfiguration configuration)
        {
            _configuration = configuration;            
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

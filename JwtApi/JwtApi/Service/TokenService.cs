using JwtApi.Models;
using JwtApi.Service.Interfaces;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace JwtApi.Service
{
    public class TokenService : ITokenService
    {
        public string GetToken(User actualUser)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(string token)
        {
            throw new NotImplementedException();
        }

        public string RefreshToken()
        {
            throw new NotImplementedException();
        }
    }
}

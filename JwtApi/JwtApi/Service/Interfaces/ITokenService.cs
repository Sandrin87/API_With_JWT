using JwtApi.Models;

namespace JwtApi.Service.Interfaces
{
    public interface ITokenService
    {
        public string GetToken(User actualUser);

        public bool IsValid(string token);

        public string RefreshToken();
    }
}

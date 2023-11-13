using JwtApi.Service;
using JwtApi.Service.Interfaces;

namespace JwtApi.Utils
{
    public static class Extensions
    {
        public static void ConfigureServices(this IServiceCollection service)
        {
            //service.AddScoped<Interface, Class>();
            service.AddTransient<ITokenService, TokenService>();
        }
    }
}

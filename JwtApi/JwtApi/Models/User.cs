using JwtApi.Models.Enum;

namespace JwtApi.Models
{
    public class User
    {
        public User(string name, string mail, string password)
        {
            Name = name;
            Mail = mail; 
            Password = password;
            Role = Role.None;
            Token = string.Empty;
        }

        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }
    }
}

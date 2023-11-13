namespace JwtApi.Models
{
    public class User
    {
        public User(string name, string mail, string password)
        {
            Name = name;
            Mail = mail; 
            Password = password;
        }

        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}

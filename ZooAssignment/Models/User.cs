using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZooAssignment
{
    public abstract class User : Human
    {
        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }
        public User()
        { 
        }
        public User(string name, string surname, int age,string login,string password) : base(name, surname, age)
        {
            Login = login;
            Password = password;
        }
        public abstract void Show();
    }
}

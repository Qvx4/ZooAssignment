using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZooAssignment
{
    public abstract class Animal
    {
        [JsonProperty("Name")]
        public string Name {get;set; }
        [JsonProperty("Nikname")]
        public string Nickname { get; set; }
        [JsonProperty("Age")]
        public int Age { get; set; }
        [JsonProperty("Weight")]
        public double Weight { get; set; }
        [JsonProperty("WalterNumber")]
        public int WalterNumber { get; set; }
        [JsonProperty("DateTime")]
        public DateTime DateTime { get; set; }
        public Animal()
        {

        }
        public Animal(string name, string nickname, int age, double weight, int walterNumber, DateTime dateTime)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
            Weight = weight;
            WalterNumber = walterNumber;
            DateTime = dateTime;
        }
        public abstract void Show();
        public abstract bool Change(int walterNumber);

    }
}

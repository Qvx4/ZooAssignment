using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZooAssignment
{
    public class Visitor : User
    {
        [JsonProperty("Balance")]
        public double Balance { get; set; }
        [JsonProperty("Tiket")]
        public Ticket Ticket { get; set; }
        public Visitor()
        {

        }
        public Visitor(string name, string surname, int age, string lohin, string password, double balance,Ticket ticket) : base(name, surname, age, lohin, password)
        {
            Balance = balance;
            Ticket = ticket;
        }
        public override void Show()
        {
            Console.WriteLine(
                $" |1 - Имя {Name}" +
                $" |2 - Фамилия {Surname}" +
                $" |3 - Возраст {Age}" +
                $" |5 - Баланс : {Balance}");
        }
    }
}

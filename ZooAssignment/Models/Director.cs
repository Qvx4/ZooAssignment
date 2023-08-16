using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAssignment
{
    public class Director : User
    {
        public Director() : base()
        {

        }
        public Director(string name, string surname, int age, string lohin, string password) : base(name, surname, age, lohin, password)
        {
        }
        public override void Show()
        {
            Console.WriteLine(
                $" |1 - Имя {Name}\n" +
                $" |2 - Фамилия {Surname}\n" +
                $" |3 - Возраст {Age}\n");
        }
    }
}

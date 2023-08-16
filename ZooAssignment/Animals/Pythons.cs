using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ZooAssignment
{
    public class Pythons : Animal
    {
        public Pythons()
        {
            
        }
        public Pythons(string name, string nickname, int age, double weight, int walterNumber, DateTime dateTime) : base(name, nickname, age, weight, walterNumber, dateTime)
        {
        }
        public override void Show()
        {
            Console.WriteLine(
                $" |1 - Имя {Name}\n" +
                $" |2 - Кличка{Nickname}\n" +
                $" |3 - Возраст {Age}\n" +
                $" |4 - Вес {Weight}\n" +
                $" |5 - номер вальера {WalterNumber}\n" +
                $" |6 - Время поселения в зоопарк {DateTime}\n");
        }
        public override bool Change(int walterNumber)
        {
            WalterNumber = walterNumber;
            return true;
        }
    }
}

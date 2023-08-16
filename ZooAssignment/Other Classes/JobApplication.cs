using System;

namespace ZooAssignment
{
    public class JobApplication : User
    {
        public string PersonalInformation { get; set; }
        public string Experience { get; set; }
        public string ReasonForWork { get; set; }
        public JobApplication() : base()
        {

        }
        public JobApplication(string name, string surname, int age, string lohin, string password, string personalInformation, string experience, string reasonForWork) : base(name, surname, age, lohin, password)
        {
            PersonalInformation = personalInformation;
            Experience = experience;
            ReasonForWork = reasonForWork;
        }
        public override void Show()
        {
            Console.WriteLine(
             $" 1|Имя - {Name}\n" +
             $" 2|Фамилия - {Surname}\n" +
             $" 3|Возраст - {Age}\n" +
             $" 4|Персональная информация - {PersonalInformation}\n" +
             $" 5|Опыт работы если имеется - {Experience}\n" +
             $" 6|Почему хотите работать в нашем зоопарке - {ReasonForWork}\n");
        }
    }
}

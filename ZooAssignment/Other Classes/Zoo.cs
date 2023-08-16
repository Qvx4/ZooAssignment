using Newtonsoft.Json;
using System;

namespace ZooAssignment
{
    public class Zoo
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("NumberZoo")]
        public string Number { get; set; }
        [JsonProperty("User")]
        User[] Users { get; set; }
        [JsonProperty("Animal")]
        Animal[] Animals { get; set; }
        [JsonProperty("JobApplication")]
        JobApplication[] JobApplications { get; set; }
        [JsonProperty("TicketPrice")]
        public int TicketPrice { get; set; }
        public Zoo()
        {
            Users = new User[0];
            Animals = new Animal[0];
            JobApplications = new JobApplication[0];
        }
        public Zoo(string name, string address, string number)
        {
            Name = name;
            Address = address;
            Number = number;
            Users = new User[0];
            Animals = new Animal[0];
            JobApplications = new JobApplication[0];
        }
        //methot
        public int CheckLoginAndPassword(string login, string password)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login && Users[i].Password == password)
                {
                    if (Users[i].GetType() == typeof(Director))
                    {
                        return (int)Role.Director;
                    }
                    if (Users[i].GetType() == typeof(Employee))
                    {
                        return (int)Role.Employee;
                    }
                    if (Users[i].GetType() == typeof(Visitor))
                    {
                        return (int)Role.Visitor;
                    }
                }
            }
            return -1;
        }
        public bool CheckingLoginTaken(string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    return false;
                }
            }
            return true;
        }
        public bool MethotCheckAnimalNull()
        {
            if (Animals.Length == 0)
            {
                return false;
            }
            return true;
        }
        public bool MethotCheckEmployeesNull()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(Employee))
                {
                    return true;
                }
            }
            return false;
        }
        public bool MethotCheckGroupAnimal(AnimalMenu animalMenu)
        {
            switch (animalMenu)
            {
                case AnimalMenu.Boa:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Boas))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.DingoDog:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(DingoDogs))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Lion:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Lion))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Panther:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Panthers))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Python:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Pythons))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Viper:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Vipers))
                            {
                                return true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Wolv:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Wolves))
                            {
                                return true;
                            }
                        }
                    }
                    break;
            }
            return false;
        }
        public bool MethotCheckJobApplicationNull()
        {
            if (JobApplications.Length == 0)
            {
                return false;
            }
            return true;
        }
        public bool MethotCheckVisitorNull()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(Visitor))
                {
                    return true;
                }
            }
            return false;
        }
        public bool MethotCheckBalance(string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    if (((Visitor)Users[i]).Balance < TicketPrice)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool MethotTicketCheck(string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    if (((Visitor)Users[i]).Ticket.Status != "Yes")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool MethotTicketTimeCheck(string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    if (DateTime.Now.Minute >= ((Visitor)Users[i]).Ticket.DateTime.Minute + 10)
                    {
                        ((Visitor)Users[i]).Ticket.Status = "No";
                        return false;
                    }
                }
            }
            return true;
        }
        public bool MethotTicketTimeCheck(DateTime dateTime)
        {

            if (DateTime.Now.Minute >= dateTime.Minute + 10)
            {
                return false;
            }
            return true;
        }
        public bool MethotIndexCheck(int index, AnimalMenu animalMenu)
        {
            bool check = false;
            switch (animalMenu)
            {
                case AnimalMenu.Boa:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Boas) && i == index)
                            {
                                check = true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.DingoDog:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(DingoDogs) && i == index)
                            {
                                check = true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Lion:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Lion) && i == index)
                            {
                                check = true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Panther:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Panthers) && i == index)
                            {
                                check = true;

                            }
                        }
                    }
                    break;
                case AnimalMenu.Python:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Pythons) && i == index)
                            {
                                check = true;
                            }
                        }

                    }
                    break;
                case AnimalMenu.Viper:
                    {

                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Vipers) && i == index)
                            {
                                check = true;
                            }
                        }
                    }
                    break;
                case AnimalMenu.Wolv:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Wolves) && i == index)
                            {
                                check = true;
                            }
                        }

                    }
                    break;
            }
            return check;
        }
        public bool MethotIndexCheckEmployees(int index)
        {
            int number = 0;
            bool check = false;
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(Employee) && i == index)
                {
                    check = true;
                    number++;
                }
            }
            return check;
        }
        public int MethotIndexChckApplicationJob()
        {
            int number = 0;
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(JobApplication) )
                {
                    number++;
                }
            }
            return number;
        }
        public bool MethotCheckCart(string numberCart,string mouth,int year,string pinCode)
        {
            int number = 0;
            bool check = true;
            char[] charCards = numberCart.ToCharArray();
            char[] pinCards = pinCode.ToCharArray();
            char[] monthCart = mouth.ToCharArray();
            string[] checkMonth = { "01","02","03","04","05","06","07","08","09","11","12", "1","2", "3", "4", "5", "6", "7", "8", "9", "11", "12" };
            for (int i = 0; i < monthCart.Length; i++)
            {
                if (Char.IsDigit(monthCart[i]) == false)
                {
                    return false; ;
                }
            }
            for (int i = 0; i < checkMonth.Length; i++)
            {
                if (checkMonth[i] == mouth)
                {
                    check = false;
                    break;
                }
            }
            for (int i = 0; i < charCards.Length; i++)
            {
                if (charCards[i] != ' ')
                {
                    number++;
                    if (char.IsDigit(charCards[i]) == false)
                    {
                        return false;
                    }
                }
            }
            if (year < DateTime.Now.Year || number < 16 || number > 16 || check || pinCards.Length < 3)
            {
                return false;
            }
            return true;
        }
        //methot
        //add dell
        public bool AddUser(User user)
        {
            User[] addUser = new User[Users.Length + 1];
            for (int i = 0; i < Users.Length; i++)
            {
                addUser[i] = Users[i];
            }
            addUser[Users.Length] = user;
            Users = addUser;
            return true;
        }
        public bool DellUser(int index)
        {
            User[] users = new User[Users.Length - 1];
            int number = 0;
            for (int i = 0; i < Users.Length; i++)
            {
                if (i != index)
                {
                    users[number] = Users[i];
                    number++;
                }
            }
            Users = users;
            return true;
        }
        public bool AddAnimal(Animal animal)
        {
            Animal[] addAnimals = new Animal[Animals.Length + 1];
            for (int i = 0; i < Animals.Length; i++)
            {
                addAnimals[i] = Animals[i];
            }
            addAnimals[Animals.Length] = animal;
            Animals = addAnimals;
            return true;
        }
        public bool DellAnimal(int index)
        {
            Animal[] dellAnimals = new Animal[Animals.Length - 1];
            int number = 0;
            for (int i = 0; i < Animals.Length; i++)
            {
                if (i != index)
                {
                    dellAnimals[number] = Animals[i];
                    number++;
                }
            }
            Animals = dellAnimals;
            return true;
        }
        public bool AddJobApplication(JobApplication jobApplication)
        {
            JobApplication[] addJobApplications = new JobApplication[JobApplications.Length + 1];
            for (int i = 0; i < JobApplications.Length; i++)
            {
                addJobApplications[i] = JobApplications[i];
            }
            addJobApplications[JobApplications.Length] = jobApplication;
            JobApplications = addJobApplications;

            return true;
        }
        public bool DellJobApplication(int index)
        {
            JobApplication[] dellJobApplications = new JobApplication[JobApplications.Length - 1];
            int number = 0;
            for (int i = 0; i < JobApplications.Length; i++)
            {
                if (i != index)
                {
                    dellJobApplications[number] = JobApplications[i];
                    number++;
                }
            }
            JobApplications = dellJobApplications;
            return true;
        }
        public bool AddJobApplication(int index)
        {
            Employee employee = new Employee(JobApplications[index].Name, JobApplications[index].Surname, JobApplications[index].Age, JobApplications[index].Login, JobApplications[index].Password);
            AddUser(employee);
            return true;
        }
        public Animal[] Dell(int index, Animal[] animals)
        {
            Animal[] dellAnimals = new Animal[animals.Length - 1];
            int number = 0;
            if (animals.Length == 1)
            {
                return animals;
            }
            for (int i = 0; i < animals.Length; i++)
            {
                if (i != index)
                {
                    dellAnimals[number] = animals[i];
                    number++;
                }
            }
            return dellAnimals;
        }
        //add dell
        //Show
        public void ShowNumberOfAnimals()
        {
            int Boas = 0, DingoDogs = 0, Lions = 0, Panthers = 0, Pythons = 0, Vipers = 0, Wolves = 0;
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].GetType() == typeof(Boas))
                {
                    Boas++;
                }
                else if (Animals[i].GetType() == typeof(DingoDogs))
                {
                    DingoDogs++;
                }
                else if (Animals[i].GetType() == typeof(Lion))
                {
                    Lions++;
                }
                else if (Animals[i].GetType() == typeof(Panthers))
                {
                    Panthers++;
                }
                else if (Animals[i].GetType() == typeof(Pythons))
                {
                    Pythons++;
                }
                else if (Animals[i].GetType() == typeof(Vipers))
                {
                    Vipers++;
                }
                else if (Animals[i].GetType() == typeof(Wolves))
                {
                    Wolves++;
                }
            }
            Console.WriteLine(
                $"            Общее количество Зверей {Animals.Length} \n" +
                $"             1| - Boas {Boas} \n" +
                $"             2| - Dingo Dogs {DingoDogs}\n" +
                $"             3| - Lions {Lions} \n" +
                $"             4| - Panthers {Panthers} \n" +
                $"             5| - Pythons {Pythons}\n" +
                $"             6| - Vipers {Vipers}\n" +
                $"             7| - Wolves {Wolves}\n");
        }
        public void ShowJobApplication()
        {
            for (int i = 0; i < JobApplications.Length; i++)
            {
                Console.WriteLine($" : Индекс номера заявки на рабоут : {i}\n");
                JobApplications[i].Show();
            }
        }
        public void ShowAnimal(AnimalMenu animalMenu)
        {
            switch (animalMenu)
            {
                case AnimalMenu.Boa:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Boas))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.DingoDog:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(DingoDogs))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.Lion:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Lion))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.Panther:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Panthers))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.Python:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Pythons))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.Viper:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Vipers))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
                case AnimalMenu.Wolv:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Wolves))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                            }
                        }
                    }
                    break;
            }
        }
        public bool ShowAnimal(MenuOfAnimalsAtLocationOne menuOfAnimalsAtLocationOne)
        {
            bool check = false;
            int number = 0;
            switch (menuOfAnimalsAtLocationOne)
            {
                case MenuOfAnimalsAtLocationOne.DingoDog:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(DingoDogs))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Lion:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Lion))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show(); 
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Wolv:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Wolves))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Panthers:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Panthers))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
            }
            if (number == 0)
            {
                return false;
            }
            return check;
        }
        public bool ShowAnimal(MenuOfAnimalsAtLocationTwo menuOfAnimalsAtLocationTwo)
        {
            bool check = false;
            int number = 0;
            switch (menuOfAnimalsAtLocationTwo)
            {
                case MenuOfAnimalsAtLocationTwo.Pythoun:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Pythons))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
                case MenuOfAnimalsAtLocationTwo.Viper:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Vipers))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
                case MenuOfAnimalsAtLocationTwo.Boa:
                    {
                        for (int i = 0; i < Animals.Length; i++)
                        {
                            if (Animals[i].GetType() == typeof(Boas))
                            {
                                Console.WriteLine($" : Индекс животного : {i}\n");
                                Animals[i].Show();
                                number++;
                            }
                        }
                        check = true;
                    }
                    break;
            }
            if (number == 0)
            {
                return false;
            }
            return check;
        }
        public void ShowEmployees()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(Employee))
                {
                    Console.WriteLine($" : Индекс сотрудника в зоопраке : {i}");
                    Users[i].Show();
                }
            }
        }
        public void ShowInformationZoo()
        {
            Console.WriteLine($" |1 Название Зоопарка  : {Name} : \n" +
                $" |2 Адресс Зоопарка : {Address} :\n" +
                $" |3 Номер Зоопарка : {Number} :\n" +
                $" |4 Количество животных в Зоопарке : {Animals.Length} :\n");
        }
        public void ShowBalance(string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    Console.WriteLine($" |Ваш баланст > {((Visitor)Users[i]).Balance}");
                }
            }

        }
        public void ShowVisitor()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].GetType() == typeof(Visitor))
                {
                    Console.WriteLine($" Индекс поситителя в зоопарке : {i} :");
                    Users[i].Show();
                }
            }
        }
        public void ShowAnimalsInAviary(int number)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].WalterNumber == number)
                {
                    Animals[i].Show();
                }
            }
        }
        public void ShowZooPark(LocationSelectionMenu locationSelectionMenu)
        {
            switch (locationSelectionMenu)
            {
                case LocationSelectionMenu.LocationOne:
                    {
                        Console.Clear();
                        Console.Write(
                        "                                      ▄█▄                    ▄█▄       │                                                                         │                           ▄▄           .────────────────────────.\n" +
                        " .─────────────────────────────.      ████                  ████       │                                                                         │          ▄▄▄  ▄▄█▀▀▀▀▀▀▀▀██ ▀▄         |        Пантера         |\n" +
                        " |           Волк              |     ██████                ██████      │               ▒▒▒▒▒▒▒▒                           ▒▒▒▒▒▒▒▒               │         █▀▄▀▀██▄█▀▀        ▀▀ █▄       | 1 - Черной пантерой    |\n" +
                        " | 1 - Основные                |     ███████              ███████      │            │ ▒▐▒▐▒▒▒▒▌▒                         ▒▒▌▒▒▐▒▒▌▒ │            │         ▀▄ █▄  ▀      ▄▄        █      | 2 - Быстрые            |\n" +
                        " | 2 - Крупное хищное          |     ████████▄          ▄████████      │            │  ▒▀▄█▒▄▀▒                           ▒▀▄▒▌▄▀▒  │            │          █▄▄██▄  ▄▄▄  ▀▀████   ▀█      | 3 - часто прячутся     |\n" +
                        " | 3 - развито чувство обоняния|    ██████████████████████████████     │            │     ██                                 ██     │            │        ▄██████▄██████    ▀█      █     |                        |\n" +
                        " |                             |    ██████████████▀▀██████████████     │            │   ▄▄██▄                               ▄██▄    │            │      ▄███▀ ▀███▀  ███     █    ▄  ▀▄   `------------------------`\n" +
                        " `─────────────────────────────`    ████████▀▀▀▀██  ██▀▀▀▀████████     │            │                                               │            │     ███▀  ▄██▀█   ███     █    ▀████ \n" +
                        "                                    ██████▀     ██  ██     ▀██████     │     ───────`                                               `───────     │    ██▀  ▄██▀  █    ██     ▀     ▀█▀  \n" +
                        "                                    █ ▀▀▀  ▄    ██  ██    ▄  ▀▀▀ █     │                               ▐█                            ██          │   ██   ███▀    █    ▀▀     █ ▄▄▄▄▄▄█ \n" +
                        "                                   ▄█     ▀ ▀▀███▀  ▀███▀▀ ▀     █▄    │                               █ ▄                         ▄▀█▄▄▄        │  █▀  ▄███      ▀██▄▄      ▄████▀▀█  \n" +
                        "                                   ██       ▀███▀    ▀███▀       ██    │                              ▐█▀                        ▄▀  █▄▄         │ ▄▀  ▄███        ▄████████▀▀▀▀█▄▄█  \n" +
                        "                                   ███       ▀          ▀       ███    │                              ▌ ▌                         ▄▄▀  ▀▄        │ █  ▄███        ▄████▀  █▀     ██  \n" +
                        "                                   ███▄                        ▄███    │     ───────.                ▐▄ ▐▄                          .───────     │ █ ▄████      ▄██████   █ \n" +
                        "                                   ▀████▄       ▄▄▄▄▄▄      ▄█████▀    │            │                                               │            │ ▀▄████      ▄███████  ██ \n" +
                        "                                     ▀████▄     ██████     █████▀      │            │          ▄▄                                   │            │   ▀███     ▄████████  ██ \n" +
                        "                                       ▀███▄    ▀▀▀▀▀▀    ████▀        │            │          █▀                                   │            │      ▀▀▄▄ ▄█████████  ██ \n" +
                        "                                         ▀███▄   ▀▀▀▀   ▄███▀          │            │        ▐█▀▄                                   │            │          ▀▀▀████████▄ ███  \n" +
                        "                                            ▀██▄▄▄▄▄▄▄▄██▀             │            │        █ ▌                                    │            │                  ▀▀▀▀▀▀▀▀ \n" +
                        "                                               ▀▀▀▀▀▀▀▀                │            │       ▐▄▐▄                                    │            │ \n " +
                        "                                                                      │            │▄▀▀▀▄ ▄▄                           ▄▀▀▀▄ ▄▄    │            │  \n" +
                        "                                                                       │            │  ▄▀▀▄█▄ ▀▄                         ▄▀▀▄█▄ ▀▄  │            |              ▄██████▄▄▄▄                 .────────────────────────.\n" +
                        "                                                                       │            │▀    █ ▀▄                           ▀   █ ▀▄   │            │          ▄█████▀     ▄▄████▄▄            |          Лев           |\n" +
                        "                                                                       │            │     ▐▌                                 ▐▌     │            │        ▄██  ██▀ ▄▄█▀       ▀█▄▄          | 1 - Пушистая грива     |\n" +
                        "                                                   ▄█ ▄                │            │▄██████▄                             ▄██████▄  │            │       █  ▀▄ █▀ ▄████████▀▀▀▀   ▀█▄       | 2 - Очень опасны вид   |\n" +
                        "                                                  ▄▀█▄██               │            │                   ▐█                          │            │      ▄█▀▄▄█▄ ▄██▀ ▄▄  ▀█████▄▄   █▄      | 3 - Обитают в Африке   |\n" +
                        "                                                ▄█▀ ████               │     ───────`                   █ ▄                         `───────     │      ██▄ ▄▀▀▀▀████████  █████▄    ▀█     |                        |\n" +
                        " .─────────────────────────────.              ▄██▀▄████▄▄▄             │                                ▐█▀                                      │      █▀        ████▀   ▄████████▄  ▀█    `────────────────────────`\n" +
                        " |                             |         ▄▄████████████▀▀▀███▄         │                                ▌ ▌                                      │    ▄█▀   ██      ██ ▀▀▀█████▄ ▀▀█▄  ▀█\n" +
                        " |       Собака Динго          |       ███████████████▀  ▄▄▄▀█▄        │                ▐█             ▐▄ ▐▄                                     │  ▄▀   ▄ ▀   ▀    ▀█▄    █████    ██  █▄\n" +
                        " | 1 - Эта порода дикой собаки |     ▄████████████▀▀▀▀    ▀▀▀ ▀▀▄      │                █ ▄                                                      │▄▀    ▀           ▄▀█  ▀▄▄██ █     ██ ██\n" +
                        " | 2 - обитает в Австралии     |    ▄██████████▄                 ▀▀▄▄  │     ───────.  ▐█▀                                          .───────     │▀██▀▀      ▄▄█  ▄ █ ▀   ███  █      ████\n" +
                        " | 3 - не умеет лаять          |   ▄████████████                     ██│            │  ▌ ▌                                          │            │ █▀      ▀████ ▄█ █   ▄ ██   █   █▄ ████\n" +
                        " |                             |    ████████████▄                  ▄▄▀ │            │ ▐▄ ▐▄                                         │            │  █▄▄    ▄██████▀ █▀ ▄██▀   █▀   ██▄████\n" +
                        " `─────────────────────────────`    ▀████████▀▀    ▄▄██████████████▀   │            │                                               │            │  █  ▀▀███████▀ ▄██ ▄█▀    ▀     ██████▀\n" +
                        "                                     ██████▀      █████▀▀              │            │                                               |            │  █▄▄▄▄██████ ▄█▀▀▄█▀           ███████\n" +
                        "                                      ████▀      █████                 │            │                                               │            │  ▀▀▀ ▄██████▀▀ ▄█▀    ▄▀  ▄  ▄███████\n" +
                        "                                       ▀█▀      ▀█████                 │    ▄██▄    │                                               │   ▄██▄     │     ▄█▀███▀   ██    ▄▀   ▄███████▀\n" +
                        "                                                 ▀█████                │   ▐█ ▀▄▌   │                                               │  ▐▄▀ █▌    │     ██ ▀█    ██   ▄█▀  ▄▄██████▀\n" +
                        "                                                   ▀▀▀███▄             │    ▀█▄ ▌   │                                               │  ▐ ▄█▀     │      ██ ▀▄   ██▄ ██  ▄███████▀\n" +
                        "                                                                       │█▄▄▄▄▄█▌    │                                               │    ▐█▄▄▄▄▄█│       ██ ▀▄   ██▄ ██ ██▀▀\n" +
                        "                                                                       │▐█████▀     │── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ──│     ▀█████ |        ██▄▄█▄▄▄██▄▄█▄█▀\n" +
                        "                                                                                           |1 - Dingo Dog       |3 - Wolf  \n" +
                        "                                                                                           |2 - Lion            |4 - Panther\n" +
                        "                                                                                                |5 - Пойти на некст локацию \n" +
                        "                                                                                                |6 - Выйти с зоопарка\n" +
                        "                                                                                                       |Ввод > ");
                    }
                    break;
                case LocationSelectionMenu.LocationTwo:
                    {
                        Console.Clear();
                        Console.Write(
                            "                             $$$$$$                          │                                                                        │\n" +
                            "                          $$$__$$_$$$                        │                                                                        │\n" +
                            "                         $____¶¶___$$§§                      │                                                                        │\n" +
                            "                          ¶¶¶¶________$§§§                   │                        ▒▓▒▓▒▓▒▓▒▓▒▓ ▄▀▀▀▄                              │\n" +
                            "                           $$$$$$___$__$§§§                  │                         ██▀████▀██  ▀▄▀  █                             │\n" +
                            "                              §§§$$___$_$§§§§                │                        O▀████████▀O     █                              │   .----------------------------------------------------------------.\n" +
                            "                            §§§§§$___$_$§§§§§                │                           ▀█▄▄█▀        █                              │   |        Удав                                                    |\n" +
                            "                            §§§§§$___$$$§§§§§                │           .───────────────────────────────────────────────────────     │   | 1 - дно из трёх подсемейств семейства ложноногих               |\n" +
                            "                            §§§§$$_$___$§§§§§                │           │                                                            │   | 2 - Главный отличительный от питонов                           |\n" +
                            "                           §§§§§§$__$_$$§§§§§                │           │   ▒▒▒▒▒▒▒▒                                                 │   | 3 - признак — отсутствие надглазничной кости и яйцеживорождение|\n" +
                            "                           §§§§§$$___$$§§§§§§                │           │  ▒▐▒▐▒▒▒▒▌▒                                   .───────     │   `----------------------------------------------------------------`\n" +
                            "                          §§§§§§$__$_$$§§§§§                 │           │   ▒▀▄█▒▄▀▒                                    │            │\n" +
                            "                          §§§§$$___$_$§§§§§                  │           │      ██                              ▒▒▒▒▒▒▒▒ │            │\n" +
                            " .--------------------.   §§§$$___$_$$§§§§                   │           │    ▄▄██▄                            ▒▐▒▐▒▒▒▒▌▒│            │\n" +
                            " |       Питон        |    §$$____$_$§§§§                    │           │                                      ▒▀▄█▒▄▀▒ │            │\n" +
                            " | 1 - неядовитая змея|     $____$_$$§§                      │           │                                         ██    │            │\n" +
                            " | 2 - опасный вид    |    $$___$__$$                        │           │                                       ▄▄██▄   │            │\n" +
                            " |                    |   $$______$$                         │           │                                               │            │   .--------------------.\n" +
                            " `--------------------`   $______$$_$                        │    ───────`                                               `───────     │   |       Гадюка       |\n" +
                            "                         $$_____$$_$$$      $$$$$$$$$$$      │                                                                        │   | 1 - ядовитый вид   |\n" +
                            "                         $______$   $$$$$$$$___________$     │                                                                        │   | 2 - Много видов    |\n" +
                            "                  $$$$$_$$___$_$$    $$$$$$____$$$______$    │                                                                        │   |                    |\n" +
                            "              $$$$____$$$$_$_$_$$$$$$$$____$$$$$$$$$$$__$    │    ───────.                                               .───────     │   `--------------------`\n" +
                            "             $$____$____$$___$_$$______$$$$__________$$$$$   │           │   ▒▒▒▒▒▒▒▒                                    │            │\n" +
                            "            $_____$      $_$___$$_$$$$$____________$_____$$$ │           │  ▒▐▒▐▒▒▒▒▌▒                                   │            │\n" +
                            "           $______$$$$$$$$____$_$$$_________________$$_____$$│           │   ▒▀▄█▒▄▀▒                                    │            │\n" +
                            "           $______$$     $_$____$$__________$$$$$$$$$$______$│           │      ██                                       │            │\n" +
                            "           $$_______$$$$_$$_$$_$_$$_____$$$$$$_______$______$│           │    ▄▄██▄                                      │            │\n" +
                            "            $$____________$$____$_$$$$$$$__________$$_______$│           │                                               │            │\n" +
                            "              $$___________$_____$__$$$_______$$$$$$_______$$│           │                                   ▒▒▒▒▒▒▒▒    │            │\n" +
                            "               $$$$$_ ___$$$________$$$$$$$$$___________$$   │           │                                  ▒▐▒▐▒▒▒▒▌▒   │            │\n" +
                            "                  $$$$$$$$$$_$$$________________________$$$  │           │                                   ▒▀▄█▒▄▀▒    │            │\n" +
                            "                               $$$$__________________$$$$    │           │                                      ██       │            │\n" +
                            "                                   $$$$$$$$$$$$$$$$$$$       │           │                                    ▄▄██▄      │            │\n" +
                            "                                                             │           │── ── ── ── ── ── ── ── ── ── ── ── ── ── ── ──│\n" +
                            "                                                                                 |1 - Python       |3 - Boa   \n" +
                            "                                                                                         |2 - Viper            \n" +
                            "                                                                                         |4 - Вернуться предыдущую локацию\n" +
                            "                                                                                         |5 - Выйти с зоопарка\n" +
                            "                                                                                         |Ввод > ");
                    }
                    break;
            }
        }//fix
        public void ShowAnimalInformationLocationOne(MenuOfAnimalsAtLocationOne menuOfAnimalsAtLocationOne) //fix
        {
            switch (menuOfAnimalsAtLocationOne)
            {
                case MenuOfAnimalsAtLocationOne.DingoDog:
                    {
                        Console.Clear();
                        Console.WriteLine(
                            ".-------------.\n" +
                            "|    Динго    |\n" +
                            "|   Животное  |\n" +
                            "`-------------`\n");
                        Console.WriteLine(
                            "Ди́нго — вторично одичавшая домашняя собака,\n" +
                            "единственный плацентарный хищник в фауне\n" +
                            "Австралии до прихода европейцев.\n" +
                            "Таксономический статус динго спорен.\n");

                        Console.WriteLine(
                            "  : Можно ли приручить собаку динго? :\n" +
                            " Хотя динго достаточно легко приручить и выглядит прирученный пес вполне\n" +
                            " дружелюбно (неустанно выказывает почтение и покорность хозяину, привязывается к\n" +
                            " нему всей душой и даже защищает дом и детей от возможной опасности), однако ни\n" +
                            "один скотовод не рискнет оставить на ночь ручного динго в одном загоне с овцами.\n");

                        Console.WriteLine(" : Почему Дикая собака Динго так называется? : \n" +
                            "Главная героиня повести тринадцатилетняя Таня Сабанеева. Одноклассники\n" +
                            "называют ее дикой собакой динго, потому что она обособленна, не делится своими\n" +
                            "мыслями и чувствами. У нее есть преданный рыцарь Филька, которому очень\n" +
                            "нравится Таня. Начинается повесть с приезда отца Тани с новой семьей и приемным\n" +
                            "сыном Колей.\n");

                        Console.WriteLine(" : Где находится собака динго? : \n" +
                            "Дикие собаки динго сейчас живут почти по всей территории Австралии, но основная\n" +
                            "их популяция находится в центральной и северной частях Австралии, а для того,\n" +
                            "чтобы сдерживать их распространение на более заселенные людьми южные\n" +
                            "террирории и защищать фермерские стада овец от динго, был построен самый\n" +
                            "большой забор в мире ...\n");

                        Console.WriteLine(" : Сколько живут динго? :\n" +
                            "Продолжительность жизни собаки динго доходит до 10 лет. Домашние условия\n" +
                            "увеличивают срок до 13–15. Динго имеет немаловажное значение в экосистеме\n" +
                            "Австралии – контролируют численность травоядных, и кроликов, которые быстро\n" +
                            "размножаются.\n");
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Lion://
                    {
                        Console.Clear();
                        Console.WriteLine(
                            " .──────────────────────────────────────────────────.\n" +
                            " │                                                  │\n" +
                            " │  Лев                                             │\n" +
                            " │  Животное                                        │\n" +
                            " │                                                  │\n" +
                            " .──────────────────────────────────────────────────.\n" +
                            " │  Лев — вид хищных млекопитающих, один из пяти    │\n" +
                            " │  представителей рода пантер, относящегося к      │\n" +
                            " │  подсемейству больших кошек в составе семейства  │\n" +
                            " │  кошачьих. Наряду с тигром — самая крупная из    │\n" +
                            " │  ныне живущих кошек, масса некоторых самцов      │\n" +
                            " │  может достигать 250 кг.                         │\n" +
                            " │                                                  │\n" +
                            " │  Скорость > 80 км/ч (Maximum, в рывке)           │\n" +
                            " │  Продолжительность жизни > 5 – 16 лет (Самка,    │\n" +
                            " │  взрослая особь, в дикой природе)                │\n" +
                            " │  Масса > 190 кг (Самец, взрослая особь), 130 кг  │\n" +
                            " │  (Самка, взрослая особь)                         │\n" +
                            " `──────────────────────────────────────────────────`\n");
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Wolv:
                    {
                        Console.Clear();
                        Console.WriteLine(
                          " .──────────────────────────────────────────────────.\n" +
                          " │                                                  │\n" +
                          " │  Волк (Wolf)                                     │\n" +
                          " │  Животное                                        │\n" +
                          " │                                                  │\n" +
                          " .──────────────────────────────────────────────────.\n" +
                          " │  Волк, или серый волк, или обыкновенный волк, —  │\n" +
                          " │  вид хищных млекопитающих из семейства псовых.   │\n" +
                          " │  Наряду с койотом, обыкновенным шакалом и ещё    │\n" +
                          " │  несколькими видами составляет род волков.       │\n" +
                          " │  Кроме того, как показывают результаты изучения  │\n" +
                          " │  последовательности ДНК и дрейфа генов,          │\n" +
                          " │  является прямым предком домашней собаки.        │\n" +
                          " |                                                  │\n" +
                          " │  Рост > 80 – 85 см (взрослая особь, в плечах)    │\n" +
                          " │  Продолжительность жизни > 16 лет (Самец, В      │\n" +
                          " │  неволе), 14 лет (Самка, в дикой природе)        │\n" +
                          " │  Масса > 30 – 80 кг (Самец, взрослая особь), 23 –│\n" +
                          " │  55 кг (Самка, взрослая особь)                   │\n" +
                          " `──────────────────────────────────────────────────`\n");
                    }
                    break;
                case MenuOfAnimalsAtLocationOne.Panthers:
                    {
                        Console.Clear();
                        Console.WriteLine(
                          " .──────────────────────────────────────────────────.\n" +
                          " │                                                  │\n" +
                          " │  Леопард (panther)                               │\n" +
                          " │  Животное                                        │\n" +
                          " │                                                  │\n" +
                          " .──────────────────────────────────────────────────.\n" +
                          " │  Леопард, или барс, или пантера — вид хищных     │\n" +
                          " │  млекопитающих семейства кошачьих, один из пяти  │\n" +
                          " │  представителей рода пантера, относящегося к     │\n" +
                          " │  подсемейству больших кошек. В XX веке был       │\n" +
                          " │  внесён в Красную книгу МСОП, в Красную книгу    │\n" +
                          " │  а также в охранные документы других стран.      │\n" +
                          " │                                                  │\n" +
                          " |  Cкорость > 58 км/ч (Maximum, бег)               │\n" +
                          " │  Рост > 80 – 85 см (взрослая особь, в плечах)    │\n" +
                          " │  Продолжительность жизни: 12 – 17 лет            │\n" +
                          " │  неволе), 14 лет (Самка, в дикой природе)        │\n" +
                          " │  Масса: 31 кг (Самец, популяция в прибрежных     │\n" +
                          " │  горах Южной Африки), 23 – 27 кг (Самка,         │\n" +
                          " │   популяция в Сомали)                            │\n" +
                          " │                                                  │\n" +
                          " `──────────────────────────────────────────────────`\n");
                    }
                    break;
            }
        }
        public void ShowAnimalInformationLocationTwo(MenuOfAnimalsAtLocationTwo menuOfAnimalsAtLocationTwo)
        {
            switch (menuOfAnimalsAtLocationTwo)
            {
                case MenuOfAnimalsAtLocationTwo.Boa:
                    {
                        Console.Clear();
                        Console.WriteLine(
                            " o ─────────────────────────────────────────────── o\n" +
                            " │                                                 │\n" +
                            " │ Удавы                                           │\n" +
                            " │ Змея                                            │\n" +
                            " o ─────────────────────────────────────────────── o\n" +
                            " │                                                 │\n" +
                            " │ Удавы — одно из трёх подсемейств семейства      │\n" +
                            " │ ложноногих. Главный отличительный от питонов    │\n" +
                            " │ признак — отсутствие надглазничной кости и      │\n" +
                            " │ яйцеживорождение.                               │\n" +
                            " o ─────────────────────────────────────────────── o\n");
                    }
                    break;
                case MenuOfAnimalsAtLocationTwo.Viper:
                    {
                        Console.Clear();
                        Console.WriteLine(
                            " o ──────────────────────────────────────────────── o\n" +
                            " │                                                  │\n" +
                            " │ Обыкновенная гадюка                              │\n" +
                            " │  Змея                                            │\n" +
                            " o ──────────────────────────────────────────────── o\n" +
                            " │                                                  │\n" +
                            " │ Обыкновенная гадюка — вид ядовитых змей рода     │\n" +
                            " │ настоящих гадюк семейства гадюковых, часто       │\n" +
                            " │ встречающийся в Европе и Азии. В отличие от      │\n" +
                            " │ других представителей семейства, предпочитает    │\n" +
                            " │ более низкие температуры и встречается либо на   │\n" +
                            " │ более высоких широтах, либо в горах до 2600 м    │\n" +
                            " │ над уровнем моря.                                │\n" +
                            " o ──────────────────────────────────────────────── o\n");
                    }
                    break;
                case MenuOfAnimalsAtLocationTwo.Pythoun:
                    {
                        Console.Clear();
                        Console.WriteLine(
                            " o ─────────────────────────────────────────────────── o\n" +
                            " │   Питоны                                            │\n" +
                            " │    Змея                                             │\n" +
                            " │                                                     │\n" +
                            " o ─────────────────────────────────────────────────── o \n" +
                            " │                                                     │\n" +
                            " │ Питоны — семейство неядовитых змей. В               │\n" +
                            " │ настоящее время насчитывается 9 родов и 41          │\n" +
                            " │ видов. В более узком смысле питоны —                │\n" +
                            " │ представители рода Python.                          │\n" +
                            " │ Продолжительность жизни: Королевский питон: 30 лет  │\n" +
                            " o ─────────────────────────────────────────────────── o");
                    }
                    break;
            }
        }
        //Show
        //Change
        public bool ChangeNumberAviary(int walterNumber, int indexAnimal)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (i == indexAnimal)
                {
                    Animals[i].Change(walterNumber);
                }
            }
            return true;
        }
        public bool ChangeBalance(double balance, string login)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    ((Visitor)Users[i]).Balance = balance;
                }
            }
            return true;
        }
        public bool WithdrawalTicketBalance(string login, DateTime dateTime)
        {
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].Login == login)
                {
                    ((Visitor)Users[i]).Balance -= TicketPrice;
                    ((Visitor)Users[i]).Ticket.Status = "Yes";
                    ((Visitor)Users[i]).Ticket.DateTime = dateTime;
                }
            }
            return true;

        }
        //Change
        //Search
        public bool Search(string nickname)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].Nickname == nickname)
                {
                    Animals[i].Show();
                }
            }
            return true;
        }
        public bool Search(int age)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].Age == age)
                {
                    Animals[i].Show();
                }
            }
            return true; ;
        }
        public bool Search(double weight)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].Weight == weight)
                {
                    Animals[i].Show();
                }
            }
            return true;
        }
        public bool Search(long walterNumber)
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].WalterNumber == walterNumber)
                {
                    Animals[i].Show();
                }
            }
            return true;
        }
        public bool Search(Animal animal, DateTime? dateTime)
        {
            Animal[] animals = Animals;
            if (animal.Name != "")
            {
                bool check = false;
                for (int i = 0; i < Animals.Length; i++)
                {
                    if (Animals[i].Name == animal.Name)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    for (int j = 0; j < animals.Length; j++)
                    {
                        if (Animals[i].Name != animals[j].Name)
                        {
                            animals = Dell(j, animals);
                            j--;
                        }
                    }
                }
            }
            if (animal.Nickname != "")
            {
                bool check = false;
                for (int i = 0; i < Animals.Length; i++)
                {
                    if (Animals[i].Nickname == animal.Nickname)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    for (int j = 0; j < animals.Length; j++)
                    {
                        if (Animals[i].Nickname != animals[j].Nickname)
                        {
                            animals = Dell(j, animals);
                            j--;
                        }
                    }
                }
            }
            if (animal.Age != 0)
            {
                bool check = false;
                for (int i = 0; i < Animals.Length; i++)
                {
                    if (Animals[i].Age == animal.Age)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    for (int j = 0; j < animals.Length; j++)
                    {
                        if (animals.Length == 1)
                        {
                            break;
                        }
                        if (Animals[i].Age != animals[j].Age)
                        {
                            animals = Dell(j, animals);
                            j--;
                        }
                    }
                }
            }
            if (animal.Weight != 0)
            {
                bool check = false;
                for (int i = 0; i < Animals.Length; i++)
                {
                    if (Animals[i].Weight == animal.Weight)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    for (int j = 0; j < animals.Length; j++)
                    {
                        if (animals[i].Weight != animals[j].Weight)
                        {
                            animals = Dell(j, animals);
                            j--;
                        }
                    }
                }
            }
            if (animal.WalterNumber != 0)
            {
                bool check = false;
                for (int i = 0; i < Animals.Length; i++)
                {
                    if (Animals[i].WalterNumber == animal.WalterNumber)
                    {
                        check = true;
                        break;
                    }
                }
                if (check = false)
                {
                    for (int i = 0; i < animals.Length; i++)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
                for (int i = 0; i < Animals.Length; i++)
                {
                    for (int j = 0; j < animals.Length; j++)
                    {
                        if (animals[i].WalterNumber != animals[j].WalterNumber)
                        {
                            animals = Dell(j, animals);
                            j--;
                        }
                    }
                }
            }
            if (animals.Length == 0)
            {
                return false;
            }
            if (dateTime != null)
            {
                for (int i = 0; i < animals.Length; i++)
                {
                    if (animals == null)
                    {
                        break;
                    }
                    if (dateTime.Value.Month != animals[i].DateTime.Month ||
                        dateTime.Value.Year != animals[i].DateTime.Year ||
                        dateTime.Value.Hour != animals[i].DateTime.Hour ||
                        dateTime.Value.Minute != animals[i].DateTime.Minute ||
                        dateTime.Value.Second != animals[i].DateTime.Second)
                    {
                        animals = Dell(i, animals);
                        i--;
                    }
                }
            }
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Show();
            }

            return true;
        }
        //Search
    }
}

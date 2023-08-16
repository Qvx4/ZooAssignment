using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Threading;

namespace ZooAssignment
{
    internal class Program
    {
        static void ShowGetes()
        {
            Console.Write(
                                               "                                                  █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\n" +
                                               "                                                  █  ╦ ╦╔╗╦ ╔╗╔╗╔╦╗╔╗  █\n" +
                                               "                                                  █  ║║║╠ ║ ║ ║║║║║╠   █\n" +
                                               "                                                  █  ╚╩╝╚╝╚╝╚╝╚╝╩ ╩╚╝  █\n" +
                                               "                                                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█\n" +
                                               "                                                        ██████████\n" +
                                               "                                                      ███╬╬    ╬╬███\n" +
                                               "                                                     ███╬╬      ╬╬███\n" +
                                               "                                                    ███╬╬╬      ╬╬╬███\n" +
                                               "                                                   ███╬╬╬╬      ╬╬╬╬███\n" +
                                               "                                                  ███╬╬╬╬╬      ╬╬╬╬╬███\n" +
                                               "                                                 ███╬╬╬╬╬╬      ╬╬╬╬╬╬███\n" +
                                               "                                                 ██╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬██\n" +
                                               "                                                 ██╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬██\n" +
                                               "                                                 ██╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬██\n" +
                                               "                                                ███╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬███\n" +
                                               "                                                ███╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬███\n" +
                                               "                                               ████╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬████\n" +
                                               "                                              █████╬╬╬╬╬╬╬      ╬╬╬╬╬╬╬█████\n" +
                                               "                                                      |1 - Войти \n" +
                                               "                                                      |2 - Выйти\n" +
                                               "                                                      |Ввод > ");
        }
        static void ShowTicket()
        {
            Console.WriteLine(
                                                           ".─────────────────.─────────────────────────────────────.\n" +
                                                           "█   Welcom 2022   | .─────────────────────────────────. █\n" +
                                                           "█─────────────────| │                                 │ █\n" +
                                                           " )    (--)        | │           З О О П А Р К         │ █\n" +
                                                           "  )  ( 10 )years  | │                                 │ █\n" +
                                                           "   )  (--)        | │  ███▅▄▄▄▄▄▄▄▄▄        ▄▄▄       │ █\n" +
                                                           "   )              | │ ██▐████████████     ▄▀░▄░▀▄     │ █\n" +
                                                           "  ) ║|║|║|║|║|║|  | │▐█▀████████████▌▌    █░█▄▀░█     │ █\n" +
                                                           " )  |║|║|║|║|║|║  | │▐ ▀▀▀▐█▌▀▀███▀█ ▌    █░▀▄▄▀█▄█▄▀ │ █\n" +
                                                           "█   A 0 9 D V  A  | │▐▄   ▄█   ▄█▌▄█     ▄▄█▄▄▄▄███▀  │ █\n" +
                                                           "█                 | `─────────────────────────────────` █\n" +
                                                           "`─────────────────`─────────────────────────────────────`\n");
        }
        static void ShowMenuSerch()
        {
            Console.Write(
                "o----------------------------------------o\n" +
                "|     Меню для поиска по парамитрам      |\n" +
                "o----------------------------------------o\n" +
                "|        |1 - По кличке                  |\n" +
                "|        |2 - По возрасту                |\n" +
                "|        |3 - По весу                    |\n" +
                "|        |4 - По номеру вальера          |\n" +
                "|        |5 - Комбинация всех полей      |\n" +
                "o----------------------------------------o\n" +
                "|Ввод > ");
        }
        static void ShowReplenishmentCheck(double number, DateTime dateTime)
        {
            Console.WriteLine(
            ".-------------------------------.\n" +
            "|  .--------------------------. |\n" +
            "|  |                          | |\n" +
            "|  | Обработка прошла успешно | |\n" +
            "|  |                          | |\n" +
            "|  `--------------------------` |\n" +
            "o ----------------------------- o");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(
            "|                               |\n" +
            "|  ║|║║|||║|║║║║|║║║||║|║║||║║  |\n" +
            "|  ║║|║║|||║|║║║║|║║║||║|║║||║║ |\n" +
            "|  ║║║|║║|||║|║║║║|║║║||║|║║||║ |\n" +
            "|  ║║|║║|||║|║║║║|║║║||║|║║||║║ |\n" +
            "|  A  B  C  D  5  2  1  9  4 0  |\n" +
            "|                               |\n" +
            "|                               |\n" +
           $"| Дата Чека {dateTime} |\n" +
           $"|                               |\n" +
           $"`-------------------------------`\n" +
           $"        Итог пополнения = {number} \n");
        }
        static void Main(string[] args)
        {
            string name, surname, zooName = "", zooAddress = "", zooNumber = "", mainLogin = "", mainPassword = "", json = "", login = "", password = "";
            string nameAnimal, nikNameAnimal;
            int age = 0, ageAnimal, walterNumber;
            double weightAnimal;
            Zoo zoo = new Zoo();
            Director director = new Director();
            if (File.Exists("ZooPark.json"))
            {
                using (Stream stream = new FileStream("ZooPark.json", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        while (!reader.EndOfStream)
                        {
                            json += reader.ReadLine();
                        }
                    }
                }
                if (json != "")
                {
                    JsonSerializerSettings setting = new JsonSerializerSettings();
                    setting.TypeNameHandling = TypeNameHandling.All;
                    zoo = JsonConvert.DeserializeObject<Zoo>(json, setting);
                }
            }
            else
            {
                Console.WriteLine(
                    " .--------------------------------------------.\n" +
                    " |                                            |\n" +
                    " |  Ввод данных нужных для создания зоопарка  |\n" +
                    " |                                            |\n" +
                    " `--------------------------------------------`\n");
                Console.Write(" |Введите Название зоопарка > ");
                zooName = Console.ReadLine();
                Console.Write(" |Введите адресс зоопарка > ");
                zooAddress = Console.ReadLine();
                Console.Write(" |Ведите номер зоопарка > ");
                zooNumber = Console.ReadLine();
                zoo = new Zoo(zooName, zooAddress, zooName);
                Console.Clear();
                Console.WriteLine(
                   " .---------------------------------------------------------------.\n" +
                   " |                                                               |\n" +
                   " |  Ввод нужных данных для создания аккаунта дерктора зоопарка   |\n" +
                   " |                                                               |\n" +
                   " `---------------------------------------------------------------`\n");
                Console.Write(" |Введите Имя > ");
                name = Console.ReadLine();
                Console.Write(" |Введите Фамилию > ");
                surname = Console.ReadLine();
                Console.Write(" |Введите Возраст > ");
                int.TryParse(Console.ReadLine(), out age);
                Console.Write(" |Введите желаемый логгин > ");
                login = Console.ReadLine();
                Console.Write(" |Введите желаемый пароль > ");
                password = Console.ReadLine();
                director = new Director(name, surname, age, login, password);
                zoo.AddUser(director);
                JsonSerializerSettings setting = new JsonSerializerSettings();
                setting.TypeNameHandling = TypeNameHandling.All;
                json = JsonConvert.SerializeObject(zoo, setting);

                using (Stream stream = new FileStream("ZooPark.json", FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        writer.Write(json);
                    }
                }
                Console.Clear();
            }
            while (true)
            {
                Console.Write(
                    " |1 - меню \n" +
                    " |2 - Войти в Аккаунт \n" +
                    " |3 - Войти как гость \n" +
                    " |Ввод > ");
                Menu menu;
                Enum.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case Menu.Menu:
                        {
                            Console.Clear();
                            Console.Write(
                                "                                                             ██████████\n" +
                                "                                                            ████████████\n" +
                                "                                                            ██        ██\n" +
                                "                                                            ██▄▄▄▄▄▄▄▄▄█\n" +
                                "                                                            ██▀███ ███▀█\n" +
                                "1| Зарегестрировать аккаунт как посититель    █             ▀█        █▀\n" +
                                "2| Подать заявку на работу сотрудника зоопарка██                  █\n" +
                                "3| Посмотреть количество животных в зоопарке  █              ██\n" +
                                "4| Посмотреть Историю появления зоопарка      █▄            ████ ██  ████ \n" +
                                "                                               ▄███████████████  ██  ██████\n" +
                                "                                                  █████████████  ██  █████████\n" +
                                "                                                           ████  ██ █████  ███\n" +
                                "                                                            ███  ██ █████  ███\n" +
                                "                                                            ███     █████████\n" +
                                "                                                            ██      ████████▀\n" +
                                "                                                              ██████████\n" +
                                "                                                              ██████████\n" +
                                "                                                               ████████\n" +
                                "                                                                ██████████▄\n" +
                                "                                                                  █████████▀\n" +
                                "                                                                   ████  ███\n" +
                                "                                                                  ▄████▄  ██\n" +
                                "                                                                  ██████   ▀\n" +
                                "                                                                  ▀▄▄▄▄▀\n" +
                                "|Ввод >");
                            MenuStepOne menuStepOne;
                            if (Enum.TryParse(Console.ReadLine(), out menuStepOne) == false || (int)menuStepOne < 1 || (int)menuStepOne > 4)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(
                                    " .---------------------------------------.\n" +
                                    " |                                       |\n" +
                                    " |  Некоректнный Номер выбора категроии  |\n" +
                                    " |                                       |\n" +
                                    " `---------------------------------------`\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                            switch (menuStepOne)
                            {
                                case MenuStepOne.RegisterAccountVisitor:
                                    {
                                        Console.Clear();
                                        Console.WriteLine(
                                            " .----------------------------------------.\n" +
                                            " |                                        |\n" +
                                            " |  Меню создания аккаунт как посетитель  |\n" +
                                            " |                                        |\n" +
                                            " `----------------------------------------`\n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(" |Введите Имя > ");
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        name = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(" |Введите Фамилию > ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        surname = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write(" |Введите Возраст > ");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        if (int.TryParse(Console.ReadLine(), out age) == false || age < 0)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(
                                                " .------------------------------.\n" +
                                                " |                              |\n" +
                                                " |    Некоректнный Ввозраст     |\n" +
                                                " |                              |\n" +
                                                " `------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(" |Введите Логин который хотите видеть > ");
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        login = Console.ReadLine();
                                        if (zoo.CheckingLoginTaken(login) == false)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(
                                                 " .---------------------------------------------.\n" +
                                                 " |                                             |\n" +
                                                 " |  Неверный логин такой логин уже существует  |\n" +
                                                 " |                                             |\n" +
                                                 " `---------------------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write(" |Введите Пароль который хотите видеть > ");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        password = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Ticket ticket = new Ticket("no", DateTime.Now);
                                        Visitor visitor = new Visitor(name, surname, age, login, password, 0, ticket);
                                        zoo.AddUser(visitor);
                                        mainLogin = "";
                                        mainPassword = "";

                                    }
                                    break;
                                case MenuStepOne.ApplyForFobZookeeper:
                                    {
                                        Console.Clear();
                                        Console.WriteLine(
                                            " .------------------------------------------.\n" +
                                            " |                                          |\n" +
                                            " |  Меню подачи заявки на работу в зоопарк  |\n" +
                                            " |                                          |\n" +
                                            " `------------------------------------------`\n");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write(" |Введите Имя > ");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        name = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write(" |Введите Фамилию > ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        surname = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write(" |Введите Возраст > ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        if (int.TryParse(Console.ReadLine(), out age) == false || age < 0)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(
                                                " .------------------------------.\n" +
                                                " |                              |\n" +
                                                " |  Некоректнный Ввод возраста  |\n" +
                                                " |                              |\n" +
                                                " `------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write(" |Введите Логин который хотите видеть > ");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        login = Console.ReadLine();
                                        if (zoo.CheckingLoginTaken(login) == false)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(
                                                " .---------------------------------------------.\n" +
                                                " |                                             |\n" +
                                                " |  Неверный логин такой логин уже существует  |\n" +
                                                " |                                             |\n" +
                                                " `---------------------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            break;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write(" |Введите Пароль который хотите видеть > ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        password = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(" |Введите Персональную информацию о себе > ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string personalInformation = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.Write(" |Расскажите о своём опыте работы в этой сфере или возможно в других > ");
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        string experience = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.Write(" |Обьясните почему вы хотите работать в этом зоопарке и чего ожидаете > ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        string reasonForWork = Console.ReadLine();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        JobApplication jobApplication = new JobApplication(name, surname, age, login, password, personalInformation, experience, reasonForWork);
                                        zoo.AddJobApplication(jobApplication);
                                    }
                                    break;
                                case MenuStepOne.ViewNumberAnimalsInTheZoo:
                                    {
                                        Console.Clear();
                                        Console.WriteLine(
                                            " .--------------------------------------------------------.\n" +
                                            " |                                                        |\n" +
                                            " |  Информационная панель количество животных в зоопарке  |\n" +
                                            " |                                                        |\n" +
                                            " `--------------------------------------------------------`\n");
                                        zoo.ShowNumberOfAnimals();
                                    }
                                    break;
                                case MenuStepOne.SeeTheHistoryOfTheZoo:
                                    {
                                        Console.Clear();
                                        Console.WriteLine(
                                            " .--------------------.\n" +
                                            " |                    |\n" +
                                            " |  История зоопарка  |\n" +
                                            " |                    |\n" +
                                            " `--------------------`\n");
                                        Console.WriteLine(
                                            "                                                                                                   $$$$\n" +
                                            "                                                                                                  $$$$$$$\n" +
                                            "                                                                                                  $$$$$$$$     $ $ $\n" +
                                            "                                                                                                   $$$$$$$    $$$$$$\n" +
                                            "Зоологи́ческий па́рк (зоопа́рк)                                                                        $$$$$$$    $$$\n" +
                                            "учреждение для содержания животных в неволе с целью их демонстрации,                        $  $ $    $$$$$$$$$$$\n" +
                                            "сохранения, воспроизводства и изучения, в том числе и научного.                              $$$$$$   $$$$$$$$ $$\n" +
                                            "Согласно «Биологическому энциклопедическому словарю»,                                         $$$ $$$$$$$$$$$$$$$$\n" +
                                            "зоопарк представляет собой научно-просветительное учреждение,                                          $$$$$$$$$$$$\n" +
                                            "в задачи которого входят демонстрация разнообразия животного мира,                                     $$$$$$$$$$$$\n" +
                                            "распространение знаний о природе,                                                                       $$$$$$$$$$$$$$$$\n" +
                                            "пропаганда охраны животных и сохранение генофонда редких и исчезающих видов животных.                 $$$$$$$$$$$$$$   $$$\n" +
                                            " От зоосада отличается большей территорией и бо́льшим количеством животных.                           $$$$    $$$$$      $$$$\n" +
                                            "                                                                                                     $$$     $$$$$    $ $ $\n" +
                                            "                                                                                                   $$$$       $$$$\n" +
                                            "                                                                                                     $ $ $     $$$$\n" +
                                            "                                                                                                              $$$$\n" +
                                            "                                                                                                 $$$$$$       $$$$\n" +
                                            "                                                                                                $$      $$     $$$$\n" +
                                            "                                                                                              $$$      $$     $$$\n" +
                                            "                                                                                               $$     $      $$$\n" +
                                            "                                                                                                $$          $$$\n" +
                                            "                                                                                                  $$$   $$$$$\n" +
                                            "                                                                                                    $$$$$\n");
                                    }
                                    break;
                            }
                        }
                        break;
                    case Menu.Join:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(
                                "                                               ▓▓▓▓\n" +
                                "                                             ▓▓     ▓\n" +
                                "                                             ▓▓      ▓▓                  ▓▓▓▓\n" +
                                "                                             ▓▓      ▓▓              ▓▓      ▓▓▓▓\n" +
                                "                                             ▓▓    ▓▓              ▓      ▓▓      ▓▓\n" +
                                "                                               ▓▓    ▓            ▓    ▓▓    ▓▓▓    ▓▓\n" +
                                "                                                 ▓▓   ▓        ▓    ▓▓          ▓▓    ▓\n" +
                                "                                                   ▓▓  ▓▓    ▓▓  ▓▓                ▓▓\n" +
                                "                                                   ▓▓     ▓▓    ▓▓\n" +
                                "                                                 ▓                ▓\n" +
                                "                                                ▓                   ▓\n" +
                                "                                               ▓      ^          ^   ▓\n" +
                                "                                               ▓            ❤        ▓\n" +
                                "                                               ▓                     ▓\n" +
                                "                                                 ▓▓▓        ٮ       ▓\n" +
                                "                                                     ▓▓          ▓▓\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("                                                 : Вход в Личный Аккаунт : \n");
                            Console.Write("                                                         Login > ");
                            mainLogin = Console.ReadLine();
                            Console.Write("                                                         Password > ");
                            mainPassword = Console.ReadLine();
                        }
                        break;
                    case Menu.GuestAccount:
                        {
                            Console.Clear();
                            Console.Write(" |Введите номер карты > ");
                            string numberCard = Console.ReadLine();
                            Console.Write(" |Введите меясц > ");
                            string month = Console.ReadLine();
                            Console.Write(" |Введите год > ");
                            int.TryParse(Console.ReadLine(), out int year);
                            Console.Write(" |Введите пин карты > ");
                            string pinCard = Console.ReadLine();
                            if (zoo.MethotCheckCart(numberCard, month, year, pinCard) == false)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(
                                    " .-------------------------.\n" +
                                    " |  Неверный данные карты  | \n" +
                                    " `-------------------------`\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                            string ticket = "yes";
                            DateTime dateTime = DateTime.Now;
                            Console.Clear();
                            ShowTicket();
                            ShowGetes();
                            MenuZooPark menuZooPark;
                            while (Enum.TryParse(Console.ReadLine(), out menuZooPark) == false || (int)menuZooPark < 1 || (int)menuZooPark > 2)
                            {
                                Console.Write("\n                                                      |Введите вариант > ");
                            }
                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                            {
                                Console.Clear();
                                ticket = "no";
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(
                                    " .---------------------------------.\n" +
                                    " |                                 |\n" +
                                    " |  Время дейсвтия билета истекло  |\n" +
                                    " |                                 |\n" +
                                    " `---------------------------------`\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            }
                            Console.Clear();
                            switch (menuZooPark)
                            {
                                case MenuZooPark.Enter:
                                    {
                                        bool isWork = true;
                                        while (isWork)
                                        {

                                            bool isWorks = true;
                                            MenuOfAnimalsAtLocationOne menuOfAnimalsAtLocationOne = 0;
                                            MenuOfAnimalsAtLocationTwo menuOfAnimalsAtLocationTwo = 0;
                                            LocationSelectionMenu locationSelectionMenu = 0;
                                            Console.Write(" : Выберите локацию на которую хотите пойти : \n" +
                                                " | Локация 1 \n" +
                                                " | Локация 2 \n" +
                                                " | Ввод > ");
                                            while (Enum.TryParse(Console.ReadLine(), out locationSelectionMenu) == false || (int)locationSelectionMenu < 1 || (int)locationSelectionMenu > 2)
                                            {
                                                Console.Write("\nВведите номер локации > ");
                                            }
                                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                            {
                                                Console.Clear();
                                                ticket = "no";
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .---------------------------------.\n" +
                                                    " |                                 |\n" +
                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                    " |                                 |\n" +
                                                    " `---------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                isWork = false;
                                            }
                                            while (isWorks)
                                            {
                                                switch (locationSelectionMenu)
                                                {
                                                    case LocationSelectionMenu.LocationOne:
                                                        {
                                                            zoo.ShowZooPark(locationSelectionMenu);
                                                            if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 6)
                                                            {
                                                                Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .------------------------------.\n" +
                                                                    " |                              |\n" +
                                                                    " | Некоректнный номер животного |\n" +
                                                                    " |                              |\n" +
                                                                    " `------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                            {
                                                                Console.Clear();
                                                                ticket = "no";
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                isWorks = false;
                                                            }
                                                            if (menuOfAnimalsAtLocationOne == MenuOfAnimalsAtLocationOne.NextLocation)
                                                            {
                                                                locationSelectionMenu = LocationSelectionMenu.LocationTwo;
                                                                break;
                                                            }
                                                            if (menuOfAnimalsAtLocationOne == MenuOfAnimalsAtLocationOne.Exit)
                                                            {
                                                                isWorks = false;
                                                                break;
                                                            }
                                                            zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                            Console.Write(" \n|1 - Посмотреть всех животных этого вида \n" +
                                                                          " |2 - Вернуться обратно в зоопарк \n" +
                                                                          " |Ввод > ");
                                                            ZooMenuSelection zooMenuSelection;
                                                            if (Enum.TryParse(Console.ReadLine(), out zooMenuSelection) == false || (int)zooMenuSelection < 1 || (int)zooMenuSelection > 3)
                                                            {
                                                                Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .------------------------------.\n" +
                                                                    " |                              |\n" +
                                                                    " | Некоректнный выбора категори |\n" +
                                                                    " |                              |\n" +
                                                                    " `------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                            {
                                                                Console.Clear();
                                                                ticket = "no";
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                isWork = false;
                                                            }
                                                            switch (zooMenuSelection)
                                                            {
                                                                case ZooMenuSelection.SeeAllAnimalsOfThisSpecies:
                                                                    {

                                                                        if (zoo.ShowAnimal(menuOfAnimalsAtLocationOne) == false)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.WriteLine(
                                                                                " .----------------------------------------------------------------.\n" +
                                                                                " |                                                                |\n" +
                                                                                " |  Животных в данной категории на данный момент неут в зоопарке  |\n" +
                                                                                " |                                                                |\n" +
                                                                                " `----------------------------------------------------------------`\n");
                                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                                            Console.Write(
                                                                                " |2 - Вернуться обратно в зоопарк \n" +
                                                                                " |Ввод > ");
                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                            while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                            {
                                                                                Console.Write(
                                                                                  " |2 - Вернуться обратно в зоопарк \n" +
                                                                                  " |Ввод > ");
                                                                                Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                            }
                                                                            break;

                                                                        }
                                                                        Console.Write(
                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                               " |Ввод > ");
                                                                        Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                        while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                        {
                                                                            Console.Write(
                                                                              " |2 - Вернуться обратно в зоопарк \n" +
                                                                              " |Ввод > ");
                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                        }
                                                                        break;

                                                                    }
                                                                    break;
                                                                case ZooMenuSelection.GoBackToTheZoo:
                                                                    {
                                                                        zoo.ShowZooPark(locationSelectionMenu);
                                                                        switch (locationSelectionMenu)
                                                                        {
                                                                            case LocationSelectionMenu.LocationOne:
                                                                                {
                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 4)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .------------------------------.\n" +
                                                                                            " |                              |\n" +
                                                                                            " | Некоректнный номер животного |\n" +
                                                                                            " |                              |\n" +
                                                                                            " `------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        ticket = "no";
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .---------------------------------.\n" +
                                                                                            " |                                 |\n" +
                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                            " |                                 |\n" +
                                                                                            " `---------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                                                }
                                                                                break;
                                                                            case LocationSelectionMenu.LocationTwo:
                                                                                {
                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 3)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .------------------------------.\n" +
                                                                                            " |                              |\n" +
                                                                                            " | Некоректнный номер животного |\n" +
                                                                                            " |                              |\n" +
                                                                                            " `------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        ticket = "no";
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .---------------------------------.\n" +
                                                                                            " |                                 |\n" +
                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                            " |                                 |\n" +
                                                                                            " `---------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case LocationSelectionMenu.LocationTwo:
                                                        {
                                                            zoo.ShowZooPark(locationSelectionMenu);
                                                            if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 5)
                                                            {
                                                                Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .------------------------------.\n" +
                                                                    " |                              |\n" +
                                                                    " | Некоректнный номер животного |\n" +
                                                                    " |                              |\n" +
                                                                    " `------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                            {
                                                                Console.Clear();
                                                                ticket = "no";
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                isWork = false;
                                                            }
                                                            if (menuOfAnimalsAtLocationTwo == MenuOfAnimalsAtLocationTwo.Back)
                                                            {
                                                                locationSelectionMenu = LocationSelectionMenu.LocationOne;
                                                                break;
                                                            }
                                                            if (menuOfAnimalsAtLocationTwo == MenuOfAnimalsAtLocationTwo.Exit)
                                                            {
                                                                isWorks = false;
                                                                break;
                                                            }
                                                            zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                            Console.Write(" \n |1 - Посмотреть всех животных этого вида \n" +
                                                                          " |2 - Вернуться обратно в зоопарк \n" +
                                                                          " |Ввод > ");
                                                            ZooMenuSelection zooMenuSelection;
                                                            if (Enum.TryParse(Console.ReadLine(), out zooMenuSelection) == false || (int)zooMenuSelection < 1 || (int)zooMenuSelection > 3)
                                                            {
                                                                Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .------------------------------.\n" +
                                                                    " |                              |\n" +
                                                                    " | Некоректнный выбора категори |\n" +
                                                                    " |                              |\n" +
                                                                    " `------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                            {
                                                                Console.Clear();
                                                                ticket = "no";
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                isWork = false;
                                                            }
                                                            switch (zooMenuSelection)
                                                            {
                                                                case ZooMenuSelection.SeeAllAnimalsOfThisSpecies:
                                                                    {

                                                                        if (zoo.ShowAnimal(menuOfAnimalsAtLocationTwo) == false)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                            Console.WriteLine(
                                                                                " .----------------------------------------------------------------.\n" +
                                                                                " |                                                                |\n" +
                                                                                " |  Животных в данной категории на данный момент неут в зоопарке  |\n" +
                                                                                " |                                                                |\n" +
                                                                                " `----------------------------------------------------------------`\n");
                                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                                            Console.Write(
                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                               " |Ввод > ");
                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                            while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                            {
                                                                                Console.Write(
                                                                                  " |2 - Вернуться обратно в зоопарк \n" +
                                                                                  " |Ввод > ");
                                                                                Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                            }
                                                                            break;
                                                                        }
                                                                        Console.Write(
                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                               " |Ввод > ");
                                                                        Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                        while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                        {
                                                                            Console.Write(
                                                                              " |2 - Вернуться обратно в зоопарк \n" +
                                                                              " |Ввод > ");
                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                        }
                                                                        break;
                                                                    }
                                                                    break;
                                                                case ZooMenuSelection.GoBackToTheZoo:
                                                                    {
                                                                        zoo.ShowZooPark(locationSelectionMenu);
                                                                        switch (locationSelectionMenu)
                                                                        {
                                                                            case LocationSelectionMenu.LocationOne:
                                                                                {
                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 4)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .------------------------------.\n" +
                                                                                            " |                              |\n" +
                                                                                            " | Некоректнный номер животного |\n" +
                                                                                            " |                              |\n" +
                                                                                            " `------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        ticket = "no";
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .---------------------------------.\n" +
                                                                                            " |                                 |\n" +
                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                            " |                                 |\n" +
                                                                                            " `---------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                                                }
                                                                                break;
                                                                            case LocationSelectionMenu.LocationTwo:
                                                                                {
                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 3)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .------------------------------.\n" +
                                                                                            " |                              |\n" +
                                                                                            " | Некоректнный номер животного |\n" +
                                                                                            " |                              |\n" +
                                                                                            " `------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    if (zoo.MethotTicketTimeCheck(dateTime) == false)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        ticket = "no";
                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                        Console.WriteLine(
                                                                                            " .---------------------------------.\n" +
                                                                                            " |                                 |\n" +
                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                            " |                                 |\n" +
                                                                                            " `---------------------------------`\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                        break;
                                                                                    }
                                                                                    zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                }
                                            }
                                            if (isWorks == false)
                                            {
                                                isWork = false;
                                            }
                                        }
                                    }
                                    break;
                                case MenuZooPark.Leave:
                                    {
                                    }
                                    break;
                            }
                        }
                        break;
                }
                switch (zoo.CheckLoginAndPassword(mainLogin, mainPassword))
                {
                    case (int)Role.Director:
                        {
                            bool isWork = true;
                            while (isWork)
                            {
                                JsonSerializerSettings setting = new JsonSerializerSettings();
                                setting.TypeNameHandling = TypeNameHandling.All;
                                json = JsonConvert.SerializeObject(zoo, setting);

                                using (Stream stream = new FileStream("ZooPark.json", FileMode.Create))
                                {
                                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                                    {
                                        writer.Write(json);
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" |1 - Добавлять новых сотрудников ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(" |2 - Перемещать животных по клеткам ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" |3 - Изменять цену за билет ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" |4 - Посмотреть клиентов зоопарка ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" |5 - Добавлять животных ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(" |6 - Удалять животных ");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine(" |7 - Посмотреть животных");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine(" |8 - Увольнять сотрудников");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(" |9 - посмотреть сотрудников");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(" |10 - Поиск животных по параметрам ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(" |11 - Выйти с аккаунта");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(" |Ввод > ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                DirectorMenu directorMenu;
                                Enum.TryParse(Console.ReadLine(), out directorMenu);
                                switch (directorMenu)
                                {
                                    case DirectorMenu.AddNewEmployees:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckJobApplicationNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------------.\n" +
                                                    " |  На данный момент нету активных поданных заявко  |\n" +
                                                    " `--------------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowJobApplication();
                                            Console.Write("Введите номер заявки > ");
                                            if (int.TryParse(Console.ReadLine(), out int numberApplication) == false || numberApplication < 0 || numberApplication > zoo.MethotIndexChckApplicationJob())
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-------------------------.\n" +
                                                    " |                         |\n" +
                                                    " |  Неверный номер заявки  |\n" +
                                                    " |                         |\n" +
                                                    " `-------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine(
                                                " \n.---------------------.   " +
                                                " \n| 1 - Принять заявку  |   " +
                                                " \n`---------------------`   ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write(
                                                ".-----------------------.\n" +
                                                "| 2 - Отклонить заявку  |\n" +
                                                "`-----------------------`\n" +
                                                "|Ввод > ");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Recruit recruit;
                                            if (Enum.TryParse(Console.ReadLine(), out recruit) == false || (int)recruit < 1 || (int)recruit > 2)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------.\n" +
                                                    " |  Ошибка  |\n" +
                                                    " `----------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (recruit)
                                            {
                                                case Recruit.Accept:
                                                    {
                                                        if (zoo.AddJobApplication(numberApplication))
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                            Console.WriteLine(
                                                                "                      █████████\n" +
                                                                "  ███████          ███▒▒▒▒▒▒▒▒███\n" +
                                                                "  █▒▒▒▒▒▒█       ███▒▒▒▒▒▒▒▒▒▒▒▒▒███\n" +
                                                                "   █▒▒▒▒▒▒█    ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                                "    █▒▒▒▒▒█   ██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███\n" +
                                                                "     █▒▒▒█   █▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██\n" +
                                                                "   █████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                                "   █▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                                " ██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██\n" +
                                                                "██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██\n" +
                                                                "█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██\n" +
                                                                "██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                                " █▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                                " ██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█\n" +
                                                                "  ████████████   █████████████████\n");
                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                        }
                                                        zoo.DellJobApplication(numberApplication);
                                                    }
                                                    break;
                                                case Recruit.Reject:
                                                    {

                                                        zoo.DellJobApplication(numberApplication);
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine(
                                                            "                      █████████\n" +
                                                            "                   ███▒▒▒▒▒▒▒▒███\n" +
                                                            "                 ███▒▒▒▒▒▒▒▒▒▒▒▒▒███\n" +
                                                            "               ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                            "              ██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███\n" +
                                                            "             █▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██\n" +
                                                            "   █████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                            "   █▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                            " ██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                            "██▒▒▒███████████▒▒▒▒▒▒████████▒▒▒▒▒▒▒▒██\n" +
                                                            "█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒▒██\n" +
                                                            "██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██\n" +
                                                            " █▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\n" +
                                                            " ██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█\n" +
                                                            "  ████████████   █████████████████\n" +
                                                            "       █▒▒▒█                      \n" +
                                                            "      █▒▒▒▒▒█\n" +
                                                            "     █▒▒▒▒▒▒█\n" +
                                                            "    █▒▒▒▒▒▒█\n" +
                                                            "    ███████\n");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                    }
                                                    break;
                                            }

                                        }
                                        break;
                                    case DirectorMenu.MoveAnimalsAroundTheCells:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckAnimalNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------.\n" +
                                                    " |                                            |\n" +
                                                    " |  В данный момент в зоопарке нету животных  |\n" +
                                                    " |                                            |\n" +
                                                    " `--------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write(" : Выберете Категорию животных у которого хотите поменять номер вальера  : \n" +
                                                 " .--------------------.\n" +
                                                 " |1 - boa             |\n" +
                                                 " |2 - Dingo Dog       |\n" +
                                                 " |3 - Lions           |\n" +
                                                 " |4 - Panther         |\n" +
                                                 " |5 - Pythons         |\n" +
                                                 " |6 - Viper           |\n" +
                                                 " |7 - Wolv            |\n" +
                                                 " `--------------------`\n" +
                                                 " |Ввод > ");
                                            AnimalMenu animalMenu;
                                            Enum.TryParse(Console.ReadLine(), out animalMenu);
                                            Console.Clear();
                                            if (zoo.MethotCheckGroupAnimal(animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Нету животных в зоопарке в такой категории  |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowAnimal(animalMenu);
                                            Console.Write("Введите номер индекса животного > ");
                                            if (int.TryParse(Console.ReadLine(), out int indexAnimal) == false || indexAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------.\n" +
                                                    " |  Ошибка ввода индекса  |\n" +
                                                    " `------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotIndexCheck(indexAnimal, animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-----------------------------.\n" +
                                                    " |  Ошибка в ведённом индексе  |\n" +
                                                    " `-----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write("Введите номер вольера > ");
                                            if (int.TryParse(Console.ReadLine(), out walterNumber) == false || walterNumber < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-----------------------------.\n" +
                                                    " |  Некоректный номер вальера  |\n" +
                                                    " `-----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.ChangeNumberAviary(walterNumber, indexAnimal))
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine(
                                                    " .----------------------------------------------------.\n" +
                                                    " |  Животное успешно было перенесино в другой вальер  |\n" +
                                                    " `----------------------------------------------------.\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                            }
                                        }
                                        break;
                                    case DirectorMenu.ChangeTicketPrice:
                                        {
                                            Console.Clear();
                                            Console.Write(
                                                $" .------------------------------------.\n" +
                                                $" | Цена билета на данный момент > {zoo.TicketPrice} |\n" +
                                                $" `------------------------------------`\n" +
                                                $" |1 - изменить цену \n" +
                                                $" |2 - оставить цену \n" +
                                                $" |Ввод > ");
                                            MenuByTicket menuByTicket;
                                            if (Enum.TryParse(Console.ReadLine(), out menuByTicket) == false || (int)menuByTicket < 1 || (int)menuByTicket > 2)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------.\n" +
                                                    " |  Ошибка  |\n" +
                                                    " `----------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (menuByTicket)
                                            {
                                                case MenuByTicket.ChangePrice:
                                                    {
                                                        Console.Write("Введите новую цену за билет > ");
                                                        if (int.TryParse(Console.ReadLine(), out int change) == false || change < 1)
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.WriteLine(
                                                                " .--------------------.\n" +
                                                                " | Ошибка ввода цены  |\n" +
                                                                " `--------------------`\n");
                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                            break;
                                                        }
                                                        zoo.TicketPrice = change;
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine(
                                                            " .----------------------------------.\n" +
                                                            " | Вы успешно меняли цену за билет  |\n" +
                                                            " `----------------------------------`\n");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                    }
                                                    break;
                                                case MenuByTicket.DontChangePtice:
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(
                                                            " .-------------------------------------------.\n" +
                                                            " |  Вы оставили цену такой какой она и была  |\n" +
                                                            " `-------------------------------------------`\n");
                                                    }
                                                    break;
                                            }

                                        }
                                        break;
                                    case DirectorMenu.SeeZooCustomers:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckVisitorNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " `------------------------------------------------.\n" +
                                                    " |                                                |\n" +
                                                    " |  На данный момент нету поситителей в зоопарке  |\n" +
                                                    " |                                                |\n" +
                                                    " `------------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowVisitor();
                                        }
                                        break;
                                    case DirectorMenu.AddAnimals:
                                        {
                                            Console.Clear();
                                            Console.WriteLine(
                                                " .--------------------------------------------------------.\n" +
                                                " |                                                        |\n" +
                                                " |  Введите данные Добовления нового животного в зоопарк  |\n" +
                                                " |                                                        |\n" +
                                                " `--------------------------------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.Write(" |Введите первоначальное Имя > ");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            nameAnimal = Console.ReadLine();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" |Введите кличку которую вы бы хотели дать этому животному > ");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            nikNameAnimal = Console.ReadLine();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write(" |Введите Возраст этого Животного >");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            if (int.TryParse(Console.ReadLine(), out ageAnimal) == false || ageAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------.\n" +
                                                    " |  Неверный возраст для животного  |\n" +
                                                    " `----------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(" |Введите вес Животного > ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            if (double.TryParse(Console.ReadLine(), out weightAnimal) == false || weightAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------.\n" +
                                                    " |  Неверные данные веса  |\n" +
                                                    " `------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" |Введите номер вальера в который хотите поселить животного > ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            if (int.TryParse(Console.ReadLine(), out walterNumber) == false || walterNumber < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .---------------------------------.\n" +
                                                    " |  Ошибка неверный номер вальера  |\n" +
                                                    " `---------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            DateTime dateTime = DateTime.Now;
                                            Console.Clear();
                                            Console.Write(" : Выберете Животного которого хотите добавить : \n" +
                                                " .--------------------.\n" +
                                                " |1 - boa             |\n" +
                                                " |2 - Dingo Dog       |\n" +
                                                " |3 - Lions           |\n" +
                                                " |4 - Panther         |\n" +
                                                " |5 - Pythons         |\n" +
                                                " |6 - Viper           |\n" +
                                                " |7 - Wolv            |\n" +
                                                " `--------------------`\n" +
                                                " |Ввод > ");
                                            AnimalMenu animalAddMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalAddMenu) == false || (int)animalAddMenu < 1 || (int)animalAddMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-------------------------------------.\n" +
                                                    " |  Неверный пункт такого пункта нету  |\n" +
                                                    " `-------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (animalAddMenu)
                                            {
                                                case AnimalMenu.Boa:
                                                    {
                                                        Boas boas = new Boas(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(boas);
                                                    }
                                                    break;
                                                case AnimalMenu.DingoDog:
                                                    {
                                                        DingoDogs dingoDogs = new DingoDogs(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(dingoDogs);
                                                    }
                                                    break;
                                                case AnimalMenu.Lion:
                                                    {
                                                        Lion lion = new Lion(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(lion);
                                                    }
                                                    break;
                                                case AnimalMenu.Panther:
                                                    {
                                                        Panthers panthers = new Panthers(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(panthers);
                                                    }
                                                    break;
                                                case AnimalMenu.Python:
                                                    {
                                                        Pythons pythons = new Pythons(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(pythons);
                                                    }
                                                    break;
                                                case AnimalMenu.Viper:
                                                    {
                                                        Vipers vipers = new Vipers(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(vipers);
                                                    }
                                                    break;
                                                case AnimalMenu.Wolv:
                                                    {
                                                        Wolves wolves = new Wolves(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(wolves);
                                                    }
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine(
                                                " .----------------------------------------------.\n" +
                                                " |                                              |\n" +
                                                " |  Животное было успешно добавлено в зоопарка  |\n" +
                                                " |                                              |\n" +
                                                " `----------------------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            
                                        }
                                        break;
                                    case DirectorMenu.DellAnimals:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckAnimalNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------.\n" +
                                                    " |                                            |\n" +
                                                    " |  В данный момент в зоопарке нету животных  |\n" +
                                                    " |                                            |\n" +
                                                    " `--------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write(" : Выберете Категорию животных из которых хотите удалить  : \n" +
                                                 " .--------------------.\n" +
                                                 " |1 - boa             |\n" +
                                                 " |2 - Dingo Dog       |\n" +
                                                 " |3 - Lions           |\n" +
                                                 " |4 - Panther         |\n" +
                                                 " |5 - Pythons         |\n" +
                                                 " |6 - Viper           |\n" +
                                                 " |7 - Wolv            |\n" +
                                                 " `--------------------`\n" +
                                                 " |Ввод > ");
                                            AnimalMenu animalMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalMenu) == false || (int)animalMenu < 1 || (int)animalMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |  Ошибка такого пунката нету  |\n" +
                                                    " `------------------------------`\n");
                                                break;
                                            }
                                            Console.Clear();
                                            if (zoo.MethotCheckGroupAnimal(animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Нету животных в зоопарке в такой категории  |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowAnimal(animalMenu);
                                            Console.Write("Введите номер индекса животного > ");
                                            if (int.TryParse(Console.ReadLine(), out int indexAnimal) == false || indexAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-------------------.\n" +
                                                    " |  Неверный индекс  |\n" +
                                                    " `-------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotIndexCheck(indexAnimal, animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-----------------------------.\n" +
                                                    " |  Ошибка в ведённом индексе  |\n" +
                                                    " `-----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.DellAnimal(indexAnimal))
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine(
                                                    " .-----------------------------------.\n" +
                                                    " |                                   |\n" +
                                                    " |  Животное было успешно добавлено  |\n" +
                                                    " |                                   |\n" +
                                                    " `-----------------------------------`\n");
                                            }
                                        }
                                        break;
                                    case DirectorMenu.SeeAnimals:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckAnimalNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------.\n" +
                                                    " |                                            |\n" +
                                                    " |  В данный момент в зоопарке нету животных  |\n" +
                                                    " |                                            |\n" +
                                                    " `--------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write(" : Выберете Категорию животных у которого хотите поменять номер вальера  : \n" +
                                                 " .--------------------.\n" +
                                                 " |1 - boa             |\n" +
                                                 " |2 - Dingo Dog       |\n" +
                                                 " |3 - Lions           |\n" +
                                                 " |4 - Panther         |\n" +
                                                 " |5 - Pythons         |\n" +
                                                 " |6 - Viper           |\n" +
                                                 " |7 - Wolv            |\n" +
                                                 " `--------------------`\n" +
                                                 " |Ввод > ");
                                            AnimalMenu animalMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalMenu) == false || (int)animalMenu < 1 || (int)animalMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-----------------------------.\n" +
                                                    " |  Неверный номер категрории  |\n" +
                                                    " `-----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotCheckGroupAnimal(animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Нету животных в зоопарке в такой категории  |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Clear();
                                            zoo.ShowAnimal(animalMenu);
                                        }
                                        break;
                                    case DirectorMenu.DismissEmployees:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckEmployeesNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------------------.\n" +
                                                    " |                                          |\n" +
                                                    " |  Нету сотрудников работующих в зоопарке  |\n" +
                                                    " |                                          |\n" +
                                                    " `------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowEmployees();
                                            Console.Write("Введите номер индекса сотрудника > ");
                                            if (int.TryParse(Console.ReadLine(), out int indexEmployees) == false || indexEmployees < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |  Неверный индекс сотрудника  |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotIndexCheckEmployees(indexEmployees) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-------------------------------.\n" +
                                                    " |  Неверный индекст сотрудника  |\n" +
                                                    " `-------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.DellUser(indexEmployees))
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    "         ▄▄                   ▄▄\n" +
                                                    "          ▀█                   ▀█\n" +
                                                    "          ▄█                   ▄█\n" +
                                                    "  █████████▀           █████████▀\n" +
                                                    "   ▄██████▄             ▄██████▄\n" +
                                                    " ▄██▀    ▀██▄         ▄██▀    ▀██▄\n" +
                                                    " ██        ██         ██        ██\n" +
                                                    " ██   ██   ██         ██   ██   ██\n" +
                                                    " ██        ██         ██        ██\n" +
                                                    "  ██▄    ▄██           ██▄    ▄██\n" +
                                                    "   ▀██████▀             ▀██████▀\n" +
                                                    "                       \n" +
                                                    "                       \n" +
                                                    "            ███████████\n" +
                                                    "           █           █\n" +
                                                    "          █             █ \n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                            }
                                        }
                                        break;
                                    case DirectorMenu.SeeEmployees:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckEmployeesNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------------------.\n" +
                                                    " |                                          |\n" +
                                                    " |  Нету сотрудников работующих в зоопарке  |\n" +
                                                    " |                                          |\n" +
                                                    " `------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowEmployees();
                                        }
                                        break;
                                    case DirectorMenu.SearchForAnimalsByParameters:
                                        {
                                            Console.Clear();
                                            ShowMenuSerch();
                                            MenuSerchSetting menuSerchSetting;
                                            if (Enum.TryParse(Console.ReadLine(), out menuSerchSetting) == false || (int)menuSerchSetting < 1 || (int)menuSerchSetting > 5)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Неверный номер выбора варианта              |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (menuSerchSetting)
                                            {
                                                case MenuSerchSetting.Nicknamed:
                                                    {
                                                        Console.Clear();
                                                        nikNameAnimal = Console.ReadLine();
                                                        zoo.Search(nikNameAnimal);
                                                    }
                                                    break;
                                                case MenuSerchSetting.AccordingToTheAge:
                                                    {
                                                        Console.Clear();
                                                        int.TryParse(Console.ReadLine(), out age);
                                                        zoo.Search(age);
                                                    }
                                                    break;
                                                case MenuSerchSetting.ByWeight:
                                                    {
                                                        Console.Clear();
                                                        double.TryParse(Console.ReadLine(), out weightAnimal);
                                                        zoo.Search(weightAnimal);
                                                    }
                                                    break;
                                                case MenuSerchSetting.ByAviaryNumber:
                                                    {
                                                        Console.Clear();
                                                        int.TryParse(Console.ReadLine(), out walterNumber);
                                                        zoo.Search((long)walterNumber);
                                                    }
                                                    break;
                                                case MenuSerchSetting.CombinationOfAllFields:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите имя > ");
                                                        nameAnimal = Console.ReadLine();
                                                        Console.Write(" |Введите кличку > ");
                                                        nikNameAnimal = Console.ReadLine();
                                                        Console.Write(" |Введите возраст > ");
                                                        int.TryParse(Console.ReadLine(), out age);
                                                        Console.Write(" |Введите вес > ");
                                                        double.TryParse(Console.ReadLine(), out weightAnimal);
                                                        Console.Write(" |Введите номер вальера >  ");
                                                        int.TryParse(Console.ReadLine(), out walterNumber);
                                                        DateTime dateTime = DateTime.Now;
                                                        Boas boa = new Boas(nameAnimal, nikNameAnimal, age, weightAnimal, walterNumber, dateTime);
                                                        Console.Clear();
                                                        zoo.Search(boa, null);

                                                    }
                                                    break;
                                            }
                                        }
                                        break;
                                    case DirectorMenu.Exit:
                                        {
                                            isWork = false;
                                            mainLogin = "";
                                            mainPassword = "";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case (int)Role.Employee:
                        {

                            bool isWork = true;
                            while (isWork)
                            {
                                JsonSerializerSettings setting = new JsonSerializerSettings();
                                setting.TypeNameHandling = TypeNameHandling.All;
                                json = JsonConvert.SerializeObject(zoo, setting);

                                using (Stream stream = new FileStream("ZooPark.json", FileMode.Create))
                                {
                                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                                    {
                                        writer.Write(json);
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine(" |1 - Перемещать животных по клеткам ");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine(" |2 - Добавлять животных");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" |3 - Посмотреть животных ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" |4 - Посмотреть Поситителей ");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(" |5 - Поиск животных по параметрам ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" |6 - Выйти с аккаунта");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" |Ввод > ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                EmployeeMenu employeeMenu;
                                Enum.TryParse(Console.ReadLine(), out employeeMenu);
                                switch (employeeMenu)
                                {
                                    case EmployeeMenu.MoveAnimalAroundTheCages:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckAnimalNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------.\n" +
                                                    " |                                            |\n" +
                                                    " |  В данный момент в зоопарке нету животных  |\n" +
                                                    " |                                            |\n" +
                                                    " `--------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write(" : Выберете Категорию животных у которого хотите поменять номер вальера  : \n" +
                                                 " .--------------------.\n" +
                                                 " |1 - boa             |\n" +
                                                 " |2 - Dingo Dog       |\n" +
                                                 " |3 - Lions           |\n" +
                                                 " |4 - Panther         |\n" +
                                                 " |5 - Pythons         |\n" +
                                                 " |6 - Viper           |\n" +
                                                 " |7 - Wolv            |\n" +
                                                 " `--------------------`\n" +
                                                 " |Ввод > ");
                                            AnimalMenu animalMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalMenu) == false || (int)animalMenu < 1 || (int)animalMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------.\n" +
                                                    " |  Неверный номер категории  |\n" +
                                                    " `----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Clear();
                                            if (zoo.MethotCheckGroupAnimal(animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Нету животных в зоопарке в такой категории  |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowAnimal(animalMenu);
                                            Console.Write("Введите номер индекса животного > ");
                                            if (int.TryParse(Console.ReadLine(), out int indexAnimal) == false || indexAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .----------------------------------------------.\n" +
                                                    " |                                              |\n" +
                                                    " |  Неверный номер индекса животного            |\n" +
                                                    " |                                              |\n" +
                                                    " `----------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotIndexCheck(indexAnimal, animalMenu) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-----------------------------.\n" +
                                                    " |  Ошибка в ведённом индексе  |\n" +
                                                    " `-----------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write("Введите номер вольера > ");
                                            if (int.TryParse(Console.ReadLine(), out walterNumber) == false || walterNumber < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------------ .\n" +
                                                    " |                                     |\n" +
                                                    " |  Неверный номер вольера             |\n" +
                                                    " |                                     |\n" +
                                                    " `-------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.ChangeNumberAviary(walterNumber, indexAnimal))
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine(
                                                    " .----------------------------------------------------.\n" +
                                                    " |                                                    |\n" +
                                                    " |  Животное было успешно отправлено в другой вольер  |\n" +
                                                    " |                                                    |\n" +
                                                    " `----------------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                            }
                                        }
                                        break;
                                    case EmployeeMenu.AddAnimals:
                                        {
                                            Console.Clear();
                                            Console.WriteLine(
                                                " .--------------------------------------------------------.\n" +
                                                " |                                                        |\n" +
                                                " |  Введите данные Добовления нового животного в зоопарк  |\n" +
                                                " |                                                        |\n" +
                                                " `--------------------------------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.Write(" |Введите первоначальное Имя > ");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            nameAnimal = Console.ReadLine();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write(" |Введите кличку которую вы бы хотели дать этому животному > ");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            nikNameAnimal = Console.ReadLine();
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write(" |Введите Возраст этого Животного >");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            if (int.TryParse(Console.ReadLine(), out ageAnimal) == false || ageAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный возраст животного  |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write(" |Введите вес Животного > ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            if (double.TryParse(Console.ReadLine(), out weightAnimal) == false || weightAnimal < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный вес животного      |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.Write(" |Введите номер вальера в который хотите поселить животного > ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            if (int.TryParse(Console.ReadLine(), out walterNumber) == false || walterNumber < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный номер вольера      |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            DateTime dateTime = DateTime.Now;
                                            Console.Clear();
                                            Console.Write(" : Выберете Животного которого хотите добавить : \n" +
                                                " .--------------------.\n" +
                                                " |1 - boa             |\n" +
                                                " |2 - Dingo Dog       |\n" +
                                                " |3 - Lions           |\n" +
                                                " |4 - Panther         |\n" +
                                                " |5 - Pythons         |\n" +
                                                " |6 - Viper           |\n" +
                                                " |7 - Wolv            |\n" +
                                                " `--------------------`\n" +
                                                " |Ввод > ");
                                            AnimalMenu animalAddMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalAddMenu) == false || (int)animalAddMenu < 1 || (int)animalAddMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный номер варината     |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (animalAddMenu)
                                            {
                                                case AnimalMenu.Boa:
                                                    {
                                                        Boas boas = new Boas(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(boas);
                                                    }
                                                    break;
                                                case AnimalMenu.DingoDog:
                                                    {
                                                        DingoDogs dingoDogs = new DingoDogs(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(dingoDogs);
                                                    }
                                                    break;
                                                case AnimalMenu.Lion:
                                                    {
                                                        Lion lion = new Lion(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(lion);
                                                    }
                                                    break;
                                                case AnimalMenu.Panther:
                                                    {
                                                        Panthers panthers = new Panthers(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(panthers);
                                                    }
                                                    break;
                                                case AnimalMenu.Python:
                                                    {
                                                        Pythons pythons = new Pythons(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(pythons);
                                                    }
                                                    break;
                                                case AnimalMenu.Viper:
                                                    {
                                                        Vipers vipers = new Vipers(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(vipers);
                                                    }
                                                    break;
                                                case AnimalMenu.Wolv:
                                                    {
                                                        Wolves wolves = new Wolves(nameAnimal, nikNameAnimal, ageAnimal, weightAnimal, walterNumber, dateTime);
                                                        zoo.AddAnimal(wolves);
                                                    }
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine(
                                                " .-----------------------------------.\n" +
                                                " |                                   |\n" +
                                                " |  Животное было успешно добавлено  |\n" +
                                                " |                                   |\n" +
                                                " `-----------------------------------`\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        break;
                                    case EmployeeMenu.SeeAnimals:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckAnimalNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .--------------------------------------------.\n" +
                                                    " |                                            |\n" +
                                                    " |  В данный момент в зоопарке нету животных  |\n" +
                                                    " |                                            |\n" +
                                                    " `--------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Write(" : Выберете Категорию животных у которого хотите поменять номер вальера  : \n" +
                                                 " .--------------------.\n" +
                                                 " |1 - boa             |\n" +
                                                 " |2 - Dingo Dog       |\n" +
                                                 " |3 - Lions           |\n" +
                                                 " |4 - Panther         |\n" +
                                                 " |5 - Pythons         |\n" +
                                                 " |6 - Viper           |\n" +
                                                 " |7 - Wolv            |\n" +
                                                 " `--------------------`\n" +
                                                 " |Ввод > ");
                                            AnimalMenu animalMenu;
                                            if (Enum.TryParse(Console.ReadLine(), out animalMenu) == false || (int)animalMenu < 1 || (int)animalMenu > 7)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный номер категории    |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowAnimal(animalMenu);
                                        }
                                        break;
                                    case EmployeeMenu.SeeVisitors:
                                        {
                                            Console.Clear();
                                            if (zoo.MethotCheckVisitorNull() == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " `------------------------------------------------.\n" +
                                                    " |                                                |\n" +
                                                    " |  На данный момент нету поситителей в зоопарке  |\n" +
                                                    " |                                                |\n" +
                                                    " `------------------------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            zoo.ShowVisitor();
                                        }
                                        break;
                                    case EmployeeMenu.SearchForAnimalsByParameters:
                                        {
                                            Console.Clear();
                                            ShowMenuSerch();
                                            MenuSerchSetting menuSerchSetting;
                                            if (Enum.TryParse(Console.ReadLine(), out menuSerchSetting) == false || (int)menuSerchSetting < 1 || (int)menuSerchSetting > 5)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный номер варинта      |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (menuSerchSetting)
                                            {
                                                case MenuSerchSetting.Nicknamed:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите кличку > ");
                                                        nikNameAnimal = Console.ReadLine();
                                                        zoo.Search(nikNameAnimal);
                                                    }
                                                    break;
                                                case MenuSerchSetting.AccordingToTheAge:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите возраст > ");
                                                        int.TryParse(Console.ReadLine(), out age);
                                                        zoo.Search(age);
                                                    }
                                                    break;
                                                case MenuSerchSetting.ByWeight:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите вес > ");
                                                        double.TryParse(Console.ReadLine(), out weightAnimal);
                                                        zoo.Search(weightAnimal);
                                                    }
                                                    break;
                                                case MenuSerchSetting.ByAviaryNumber:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите номер вальера > ");
                                                        int.TryParse(Console.ReadLine(), out walterNumber);
                                                        zoo.Search((long)walterNumber);
                                                    }
                                                    break;
                                                case MenuSerchSetting.CombinationOfAllFields:
                                                    {
                                                        Console.Clear();
                                                        Console.Write(" |Введите имя > ");
                                                        nameAnimal = Console.ReadLine();
                                                        Console.Write(" |Введите кличку > ");
                                                        nikNameAnimal = Console.ReadLine();
                                                        Console.Write(" |Введите возраст > ");
                                                        int.TryParse(Console.ReadLine(), out age);
                                                        Console.Write(" |Введите вес > ");
                                                        double.TryParse(Console.ReadLine(), out weightAnimal);
                                                        Console.Write(" |Введите номер вальера >  ");
                                                        int.TryParse(Console.ReadLine(), out walterNumber);
                                                        DateTime dateTime = DateTime.Now;
                                                        Boas boa = new Boas(nameAnimal, nikNameAnimal, age, weightAnimal, walterNumber, dateTime);
                                                        Console.Clear();
                                                        zoo.Search(boa, null);

                                                    }
                                                    break;
                                            }
                                        }
                                        break;
                                    case EmployeeMenu.Exit:
                                        {
                                            isWork = false;
                                            mainLogin = "";
                                            mainPassword = "";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case (int)Role.Visitor:
                        {

                            bool isWork = true;
                            while (isWork)
                            {
                                JsonSerializerSettings setting = new JsonSerializerSettings();
                                setting.TypeNameHandling = TypeNameHandling.All;
                                json = JsonConvert.SerializeObject(zoo, setting);

                                using (Stream stream = new FileStream("ZooPark.json", FileMode.Create))
                                {
                                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                                    {
                                        writer.Write(json);
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("\n |1 - Смотреть информацию про зоопарк ");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine(" |2 - Зайти в Зоопарк ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(" |3 - Купить билет(действует 10 минут с момента покупки) ");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(" |4 - Пополнить баланс");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" |5 - Выход с аккаунта");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(" |Ввод > ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                MenuVisitor menuVisitor;
                                Enum.TryParse(Console.ReadLine(), out menuVisitor);
                                switch (menuVisitor)
                                {
                                    case MenuVisitor.ViewZooInformation:
                                        {
                                            Console.Clear();
                                            zoo.ShowInformationZoo();
                                        }
                                        break;
                                    case MenuVisitor.EnterTheZoo:
                                        {
                                            Console.Clear();
                                            ShowGetes();
                                            MenuZooPark menuZooPark;
                                            if (Enum.TryParse(Console.ReadLine(), out menuZooPark) == false || (int)menuZooPark < 1 || (int)menuZooPark > 2)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный номер варината     |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .---------------------------------.\n" +
                                                    " |                                 |\n" +
                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                    " |                                 |\n" +
                                                    " `---------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (menuZooPark)
                                            {
                                                case MenuZooPark.Enter:
                                                    {
                                                        bool isWorks = true;
                                                        while (isWork)
                                                        {
                                                            Console.Clear();
                                                            bool whichZone = false;
                                                            if (zoo.MethotTicketCheck(mainLogin) == false)
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------.\n" +
                                                                    " |  Нету билета  |\n" +
                                                                    " `---------------.\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            MenuOfAnimalsAtLocationOne menuOfAnimalsAtLocationOne = 0;
                                                            MenuOfAnimalsAtLocationTwo menuOfAnimalsAtLocationTwo = 0;
                                                            LocationSelectionMenu locationSelectionMenu;
                                                            Console.Write(" : Выберите локацию на которую хотите пойти : \n" +
                                                                " | Локация 1 \n" +
                                                                " | Локация 2 \n" +
                                                                " | Ввод > ");
                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                            {
                                                                Console.Clear();
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                break;
                                                            }
                                                            while (Enum.TryParse(Console.ReadLine(), out locationSelectionMenu) == false || (int)locationSelectionMenu < 1 || (int)locationSelectionMenu > 2)
                                                            {
                                                                Console.Write("\nВведите номер локации > ");
                                                            }
                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                            {
                                                                Console.Clear();
                                                                
                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                Console.WriteLine(
                                                                    " .---------------------------------.\n" +
                                                                    " |                                 |\n" +
                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                    " |                                 |\n" +
                                                                    " `---------------------------------`\n");
                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                isWork = false;
                                                            }
                                                            while (isWorks)
                                                            {
                                                                switch (locationSelectionMenu)
                                                                {
                                                                    case LocationSelectionMenu.LocationOne:
                                                                        {
                                                                            zoo.ShowZooPark(locationSelectionMenu);
                                                                            if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 6)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .------------------------------.\n" +
                                                                                    " |                              |\n" +
                                                                                    " | Некоректнный номер животного |\n" +
                                                                                    " |                              |\n" +
                                                                                    " `------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                break;
                                                                            }
                                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .---------------------------------.\n" +
                                                                                    " |                                 |\n" +
                                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                                    " |                                 |\n" +
                                                                                    " `---------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                isWorks = false;
                                                                            }
                                                                            if (menuOfAnimalsAtLocationOne == MenuOfAnimalsAtLocationOne.NextLocation)
                                                                            {
                                                                                locationSelectionMenu = LocationSelectionMenu.LocationTwo;
                                                                                break;
                                                                            }
                                                                            if (menuOfAnimalsAtLocationOne == MenuOfAnimalsAtLocationOne.Exit)
                                                                            {
                                                                                isWorks = false;
                                                                                break;
                                                                            }
                                                                            zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                                            Console.Write(" \n|1 - Посмотреть всех животных этого вида \n" +
                                                                                          " |2 - Вернуться обратно в зоопарк \n" +
                                                                                          " |Ввод > ");
                                                                            ZooMenuSelection zooMenuSelection;
                                                                            if (Enum.TryParse(Console.ReadLine(), out zooMenuSelection) == false || (int)zooMenuSelection < 1 || (int)zooMenuSelection > 3)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .------------------------------.\n" +
                                                                                    " |                              |\n" +
                                                                                    " | Некоректнный выбора категори |\n" +
                                                                                    " |                              |\n" +
                                                                                    " `------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                break;
                                                                            }
                                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .---------------------------------.\n" +
                                                                                    " |                                 |\n" +
                                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                                    " |                                 |\n" +
                                                                                    " `---------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                isWork = false;
                                                                            }
                                                                            switch (zooMenuSelection)
                                                                            {
                                                                                case ZooMenuSelection.SeeAllAnimalsOfThisSpecies:
                                                                                    {

                                                                                        if (zoo.ShowAnimal(menuOfAnimalsAtLocationOne) == false)
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.WriteLine(
                                                                                                " .----------------------------------------------------------------.\n" +
                                                                                                " |                                                                |\n" +
                                                                                                " |  Животных в данной категории на данный момент неут в зоопарке  |\n" +
                                                                                                " |                                                                |\n" +
                                                                                                " `----------------------------------------------------------------`\n");
                                                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                                                            Console.Write(
                                                                                                " |2 - Вернуться обратно в зоопарк \n" +
                                                                                                " |Ввод > ");
                                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                            while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                                            {
                                                                                                Console.Write(
                                                                                                  " |2 - Вернуться обратно в зоопарк \n" +
                                                                                                  " |Ввод > ");
                                                                                                Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                            }
                                                                                            break;

                                                                                        }
                                                                                        Console.Write(
                                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                                               " |Ввод > ");
                                                                                        Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                        while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                                        {
                                                                                            Console.Write(
                                                                                              " |2 - Вернуться обратно в зоопарк \n" +
                                                                                              " |Ввод > ");
                                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                        }
                                                                                        break;

                                                                                    }
                                                                                    break;
                                                                                case ZooMenuSelection.GoBackToTheZoo:
                                                                                    {
                                                                                        zoo.ShowZooPark(locationSelectionMenu);
                                                                                        switch (locationSelectionMenu)
                                                                                        {
                                                                                            case LocationSelectionMenu.LocationOne:
                                                                                                {
                                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 4)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .------------------------------.\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " | Некоректнный номер животного |\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " `------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .---------------------------------.\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " `---------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                                                                }
                                                                                                break;
                                                                                            case LocationSelectionMenu.LocationTwo:
                                                                                                {
                                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 3)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .------------------------------.\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " | Некоректнный номер животного |\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " `------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                   
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .---------------------------------.\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " `---------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                                                                }
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case LocationSelectionMenu.LocationTwo:
                                                                        {
                                                                            zoo.ShowZooPark(locationSelectionMenu);
                                                                            if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 5)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .------------------------------.\n" +
                                                                                    " |                              |\n" +
                                                                                    " | Некоректнный номер животного |\n" +
                                                                                    " |                              |\n" +
                                                                                    " `------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                break;
                                                                            }
                                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                            {
                                                                                Console.Clear();
                                                                                
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .---------------------------------.\n" +
                                                                                    " |                                 |\n" +
                                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                                    " |                                 |\n" +
                                                                                    " `---------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                isWork = false;
                                                                            }
                                                                            if (menuOfAnimalsAtLocationTwo == MenuOfAnimalsAtLocationTwo.Back)
                                                                            {
                                                                                locationSelectionMenu = LocationSelectionMenu.LocationOne;
                                                                                break;
                                                                            }
                                                                            if (menuOfAnimalsAtLocationTwo == MenuOfAnimalsAtLocationTwo.Exit)
                                                                            {
                                                                                isWorks = false;
                                                                                break;
                                                                            }
                                                                            zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                                            Console.Write(" \n |1 - Посмотреть всех животных этого вида \n" +
                                                                                          " |2 - Вернуться обратно в зоопарк \n" +
                                                                                          " |Ввод > ");
                                                                            ZooMenuSelection zooMenuSelection;
                                                                            if (Enum.TryParse(Console.ReadLine(), out zooMenuSelection) == false || (int)zooMenuSelection < 1 || (int)zooMenuSelection > 3)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .------------------------------.\n" +
                                                                                    " |                              |\n" +
                                                                                    " | Некоректнный выбора категори |\n" +
                                                                                    " |                              |\n" +
                                                                                    " `------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                break;
                                                                            }
                                                                            if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                            {
                                                                                Console.Clear();
                                                                                
                                                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                Console.WriteLine(
                                                                                    " .---------------------------------.\n" +
                                                                                    " |                                 |\n" +
                                                                                    " |  Время дейсвтия билета истекло  |\n" +
                                                                                    " |                                 |\n" +
                                                                                    " `---------------------------------`\n");
                                                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                                                isWork = false;
                                                                            }
                                                                            switch (zooMenuSelection)
                                                                            {
                                                                                case ZooMenuSelection.SeeAllAnimalsOfThisSpecies:
                                                                                    {

                                                                                        if (zoo.ShowAnimal(menuOfAnimalsAtLocationTwo) == false)
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                            Console.WriteLine(
                                                                                                " .----------------------------------------------------------------.\n" +
                                                                                                " |                                                                |\n" +
                                                                                                " |  Животных в данной категории на данный момент неут в зоопарке  |\n" +
                                                                                                " |                                                                |\n" +
                                                                                                " `----------------------------------------------------------------`\n");
                                                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                                                            Console.Write(
                                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                                               " |Ввод > ");
                                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                            while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                                            {
                                                                                                Console.Write(
                                                                                                  " |2 - Вернуться обратно в зоопарк \n" +
                                                                                                  " |Ввод > ");
                                                                                                Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                            }
                                                                                            break;
                                                                                        }
                                                                                        Console.Write(
                                                                                               " |2 - Вернуться обратно в зоопарк \n" +
                                                                                               " |Ввод > ");
                                                                                        Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                        while (zooMenuSelection == ZooMenuSelection.GoBackToTheZoo == false)
                                                                                        {
                                                                                            Console.Write(
                                                                                              " |2 - Вернуться обратно в зоопарк \n" +
                                                                                              " |Ввод > ");
                                                                                            Enum.TryParse(Console.ReadLine(), out zooMenuSelection);
                                                                                        }
                                                                                        break;
                                                                                    }
                                                                                    break;
                                                                                case ZooMenuSelection.GoBackToTheZoo:
                                                                                    {
                                                                                        zoo.ShowZooPark(locationSelectionMenu);
                                                                                        switch (locationSelectionMenu)
                                                                                        {
                                                                                            case LocationSelectionMenu.LocationOne:
                                                                                                {
                                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationOne) == false || (int)menuOfAnimalsAtLocationOne < 1 || (int)menuOfAnimalsAtLocationOne > 4)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .------------------------------.\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " | Некоректнный номер животного |\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " `------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .---------------------------------.\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " `---------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    zoo.ShowAnimalInformationLocationOne(menuOfAnimalsAtLocationOne);
                                                                                                }
                                                                                                break;
                                                                                            case LocationSelectionMenu.LocationTwo:
                                                                                                {
                                                                                                    if (Enum.TryParse(Console.ReadLine(), out menuOfAnimalsAtLocationTwo) == false || (int)menuOfAnimalsAtLocationTwo < 1 || (int)menuOfAnimalsAtLocationTwo > 3)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .------------------------------.\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " | Некоректнный номер животного |\n" +
                                                                                                            " |                              |\n" +
                                                                                                            " `------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    if (zoo.MethotTicketTimeCheck(mainLogin) == false)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        
                                                                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                                                                        Console.WriteLine(
                                                                                                            " .---------------------------------.\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " |  Время дейсвтия билета истекло  |\n" +
                                                                                                            " |                                 |\n" +
                                                                                                            " `---------------------------------`\n");
                                                                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                                                                        break;
                                                                                                    }
                                                                                                    zoo.ShowAnimalInformationLocationTwo(menuOfAnimalsAtLocationTwo);
                                                                                                }
                                                                                                break;
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                            }
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            if (isWorks == false)
                                                            {
                                                                isWork = false;
                                                            }
                                                        }
                                                    }
                                                    break;
                                                case MenuZooPark.Leave:
                                                    {

                                                    }
                                                    break;
                                            }

                                        }
                                        break;
                                    case MenuVisitor.BuyTicket:
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"      Цена билета : {zoo.TicketPrice} : \n");
                                            Console.WriteLine("    : Хотите приобрести билет в зоопарк ? : \n");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine(" |1 - Да");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(" |2 - Нет ");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.Write(" |Ввод > ");
                                            TicketPurchaseMenu menuTicketPurchaseMenu;
                                            DateTime dateTime = DateTime.Now;
                                            if (Enum.TryParse(Console.ReadLine(), out menuTicketPurchaseMenu) == false || (int)menuTicketPurchaseMenu < 1 || (int)menuTicketPurchaseMenu > 2)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверный варииант выбора    |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            switch (menuTicketPurchaseMenu)
                                            {
                                                case TicketPurchaseMenu.Yes:
                                                    {
                                                        Console.Clear();
                                                        if (zoo.MethotCheckBalance(mainLogin) == false)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                                            Console.WriteLine(
                                                                " .-----------------------------------------------------.\n" +
                                                                " |                                                     |\n" +
                                                                " | Недостаточно средств на балансе для покупки билтеа  |\n" +
                                                                " |                                                     |\n" +
                                                                " `-----------------------------------------------------`\n");
                                                            Console.ForegroundColor = ConsoleColor.Gray;
                                                            break;
                                                        }
                                                        zoo.WithdrawalTicketBalance(mainLogin, dateTime);
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine(
                                                            " .----------------------------.\n" +
                                                            " |                            |\n" +
                                                            " |  Билет был куплен успешно  |\n" +
                                                            " |                            |\n" +
                                                            " `----------------------------`\n");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                        ShowTicket();
                                                    }
                                                    break;
                                                case TicketPurchaseMenu.No:
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine(
                                                            " .---------------------------------------------.\n" +
                                                            " |                                             |\n" +
                                                            " |  Вы Отказались От Покупки Билета в Зоопарк  |\n" +
                                                            " |                                             |\n" +
                                                            " `---------------------------------------------`\n");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                    }
                                                    break;
                                            }


                                        }
                                        break;
                                    case MenuVisitor.ReplenishTheBalance:
                                        {
                                            Console.Clear();
                                            zoo.ShowBalance(mainLogin);
                                            Console.Write($" |Введите номер карты > ");
                                            string numberCard = Console.ReadLine();
                                            Console.Write($" |Введите дату и срок дейсвия | \n" +
                                                $" |Введите месяц  > ");
                                            string month = Console.ReadLine();
                                            Console.Write(" |Введите год > ");
                                            int.TryParse(Console.ReadLine(), out int year);
                                            Console.Write($" |Введите пин карты  > ");
                                            string pinCard = Console.ReadLine();
                                            Console.Write(" |Введите на сколько хотите пополнить баланс > ");
                                            if (double.TryParse(Console.ReadLine(), out double howMuch) == false || howMuch < 0)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .------------------------------.\n" +
                                                    " |                              |\n" +
                                                    " |  Неверная сумма пополнения   |\n" +
                                                    " |                              |\n" +
                                                    " `------------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            if (zoo.MethotCheckCart(numberCard, month, year, pinCard) == false)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(
                                                    " .-------------------------.\n" +
                                                    " |  Неверный данные карты  | \n" +
                                                    " `-------------------------`\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                            Console.Clear();
                                            Thread.Sleep(2500);
                                            Console.WriteLine("Loading .");
                                            Thread.Sleep(1200);
                                            Console.Clear();
                                            Thread.Sleep(1700);
                                            Console.WriteLine("Loading ..");
                                            Thread.Sleep(1200);
                                            Console.Clear();
                                            Thread.Sleep(1500);
                                            Console.WriteLine("Loading ...");
                                            Console.Clear();
                                            DateTime dateTime = DateTime.Now;
                                            if (zoo.ChangeBalance(howMuch, mainLogin))
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                            }
                                            ShowReplenishmentCheck(howMuch, dateTime);
                                        }
                                        break;
                                    case MenuVisitor.Exit:
                                        {
                                            isWork = false;
                                            mainLogin = "";
                                            mainPassword = "";
                                        }
                                        break;
                                }

                            }
                        }
                        break;
                }
            }
        }
    }
}

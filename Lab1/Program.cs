using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //Console.InputEncoding = Encoding.GetEncoding(1251);

            List<string> names = new List<string>
            {
                "Anatoliy", "Anton", "Boris", "Vadim", "Viktor", "Vitaly",
                "Denis", "Dmitriy", "Ivan", "Igor", "Leonid", "Maksim",
                "Mikhail", "Nikita", "Oleg", "Pavel", "Roman", "Sergey"
            };
            List<string> surnames = new List<string>
            {
                "Antonov", "Borisov", "Vadimiev", "Viktorov", "Van", "Donskoy",
                "Denisov", "Dmitriev", "Ivanov", "Igorsto", "Leonov", "Maksimov",
                "Mikhalkov", "Nikitiev", "Oleg", "Pavlov", "Romanov", "Sergeev"
            };

            var personList1 = new PersonList();
            var personList2 = new PersonList();

            Console.WriteLine("Создание 2-х списков по 3 человека" +
                "Нажмите любую клавишу");
            for (int i = 0; i < 3; i++)
            {
                personList1.Add(Person.GetRandomPerson(names, surnames));
                personList2.Add(Person.GetRandomPerson(names, surnames));

            }
            Console.WriteLine("Выввод персон 1-го списка");
            GetAllPerson(personList1);
            Console.WriteLine("Выввод персон 2-го списка");
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Добавление новой персоны в 1-ый список");
            personList1.Add(ReadPerson());
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Копирование 2-го человека из 1-го списка в конец 2-го");
            personList2.Add(personList1.GetPersonByIndex(1));
            GetAllPerson(personList1);
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Удаление 2-го человека из 1-ого списка");
            personList1.DeletePersonByIndex(1);
            GetAllPerson(personList1);
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Очистка 2-го списка");
            personList2.Clear();
            GetAllPerson(personList1);
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();
        }

        /// <summary>
        /// Вводит Персону через консоль
        /// </summary>
        /// <returns></returns>
        static Person ReadPerson()
        {
            var personRead = new Person();
            Action action1 = () =>
            {
                personRead.Name = Console.ReadLine();
            };
            ActionHandler(action1, "Введите имя человека");

            Action action2 = () =>
            {
                personRead.Surname = Console.ReadLine();
            };
            ActionHandler(action2, "Введите фамилию человека");

            Action action3 = () =>
            {
                personRead.Age = int.Parse(Console.ReadLine());
            };
            ActionHandler(action3, "Введите возраст человека");

            Action action4 = () =>
            {
                int personReadGender;
                int.TryParse(Console.ReadLine(), out personReadGender);
                switch (personReadGender)
                {
                    case 1:
                        {
                            personRead.Gender = GenderPerson.Male;
                            return;
                        }
                    case 2:
                        {
                            personRead.Gender = GenderPerson.Female;
                            return;
                        }
                    default:
                        {
                            personRead.Gender = GenderPerson.Unknown;
                            Console.WriteLine("Присвоено значение по умолчанию");
                            break;
                        }
                }
            };
            ActionHandler(action4, "Введите пол человека:" +
               " 1 -  Male " +
               " 2 - Female ");
            return personRead;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action">выполняемое действие</param>
        /// <param name="inputMessage"> Сообщение, отображаемое в консоли</param>
        private static void ActionHandler(Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again!");
                }
            }
        }

        /// <summary>
        /// Выводит на экран персон списка
        /// </summary>
        /// <param name="list"> Список персон</param>
        public static void GetAllPerson(PersonList list)
        {
            for (int i = 0; i < list.Length(); i++)
            {
                Console.WriteLine(list.GetPersonByIndex(i).Info);
            }

        }


    }
}
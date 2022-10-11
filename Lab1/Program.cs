using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace View
{
   
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

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

            Console.WriteLine("Creating 2 list of 3 people");

            var rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                personList1.Add(Person.GetRandomPerson(names, surnames, rnd));
                personList2.Add(Person.GetRandomPerson(names, surnames, rnd));
            }

            Console.WriteLine("Output of persons of the 1st list ");
            GetAllPerson(personList1);
            Console.WriteLine("Output of persons of the 2nd list");
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Adding new person to 1st list");
            personList1.Add(ReadPerson());
            Console.ReadKey();
            Console.WriteLine();

            GetAllPerson(personList1);
            Console.WriteLine("-------------");
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("Copying 2nd person from 1st list to the end of 2nd list");
            personList2.Add(personList1.GetPersonByIndex(1));
            GetAllPerson(personList1);
            Console.WriteLine("-------------");
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Deleting 2nd person from 1st list");
            personList1.DeletePersonByIndex(1);
            GetAllPerson(personList1);
            Console.WriteLine("-------------");
            GetAllPerson(personList2);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Deleting 2nd list");
            personList2.Clear();
            GetAllPerson(personList1);
            Console.WriteLine("-------------");
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
            Action actionReadName = () =>
            {
                personRead.Name = Console.ReadLine();
            };
            ActionHandler(actionReadName, "Enter name of person");
            Action actionReadSurname = () =>
            {
                personRead.Surname = Console.ReadLine();
            };
            ActionHandler(actionReadSurname, "Enter surname of person");
            Action actionReadAge = () =>
            {
                personRead.Age = int.Parse(Console.ReadLine());
            };
            ActionHandler(actionReadAge, $"Enter age of person: value must be in range:" +
                $" {Person.MinAge} - {Person.MaxAge} ");
            Action actionReadGender = () =>
            {
               int personGender= Convert.ToInt32(Console.ReadLine());
                switch (personGender)
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
                    case 3:
                        {
                            personRead.Gender = GenderPerson.Unknown;
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Value must be: 1, 2, 3 ");
                            break;
                        }
                }
            };
            ActionHandler(actionReadGender, "Enter gender of person:" +
               " 1 - Male " +
               " 2 - Female "+
               " 3 - Unknown" );
            return personRead;
        }

        /// <summary>
        /// Выполняет действие, иначе выбрасывает исключение
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
                catch (Exception e)
                {
                    if (e is ArgumentException || e is FormatException)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Try again!");
                    }
                    else
                    {
                        throw;
                    }
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
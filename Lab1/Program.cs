using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace View
{
    //TODO: XML

    public class Program
    {
        //TODO: XML
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<string> maleNames = new List<string>
            {
                "Anatoliy", "Anton", "Boris", "Vadim", "Viktor", "Vitaly",
                "Denis", "Dmitriy", "Ivan", "Igor", "Leonid", "Maksim",
                "Mikhail", "Nikita", "Oleg", "Pavel", "Roman", "Sergey"
            };
            List<string> femaleNames = new List<string>
            {
                "Bobbie", "Beth", "Sara", "Amandan",
                "Ruth", "Jennifer", "Anna", "Patricia",
                "Sharon", "Mary", "Kelly", "Jeanne",
                "Darlene", "Stephanie", "Jamie", "Rebecca",
                "Deborah", "Viola", "Wanda"
            };
            List<string> surnames = new List<string>
            {
                "Antonov", "Borisov", "Vadimiev", "Viktorov", "Van", "Donskoy",
                "Denisov", "Dmitriev", "Ivanov", "Igorsto", "Leonov", "Maksimov",
                "Mikhalkov", "Nikitiev", "Oleg", "Pavlov", "Romanov", "Sergeev"
            };
            List<string> workplaces = new List<string>
            {
                "Power industry", "Gas station", "Post office",
                "Power plant", "Data center", "Car manufacturing",
                "Design office", "Window manufacturing", "Network company"
            };
            List<string> facilities = new List<string>
            {
                "Church school", "female gymnasium", "Middle school",
                "High school", "Low school", "Physics Math school",
                "social studies school", "nursery school"
            };

            var list1 = new PersonList();
            
           
            Console.WriteLine("Creating a list of 7 people");
            var rnd = new Random();
            int randomNumber = rnd.Next(1, 4);

            for (int i = 0; i < randomNumber; i++)
            {
                int genderType = rnd.Next(0, 2);
                bool marriageStatus = Convert.ToBoolean(rnd.Next(0,2));
                List<string> firstName = genderType == 0 ? (maleNames) : femaleNames;
                List<string> secondName = genderType == 0 ? (femaleNames) : maleNames;
                //TODO: RSDN
                list1.Add(Adult.GetPair(firstName, secondName, surnames, workplaces, marriageStatus, genderType, rnd));
 
            }
   
            for (int i=0; i<7-randomNumber; i++)
            {
                int genderType = rnd.Next(0, 2);
                List<string> firstName = genderType == 0 ? (maleNames) : femaleNames;
                List<string> secondName = genderType == 0 ? (femaleNames) : maleNames;

               //TODO: RSDN
                    list1.Add(Child.GetChildWithParrent(firstName, secondName, surnames, facilities,genderType, rnd));
           
            }
        
            for (int i = 0; i < list1.Length(); i++)
            {
                Console.WriteLine(list1.GetPersonByIndex(i).Info());
                Console.WriteLine("");
            }
            Console.WriteLine("");
            var fourthPerson = list1.GetPersonByIndex(3);
            Console.WriteLine("4th person in the list is of the following object type:");
            Console.WriteLine($"{fourthPerson.GetType()}");
            Console.WriteLine($"{fourthPerson.Info()}");

            switch (fourthPerson)
            {
                case Child fourthChild:
                    Console.WriteLine(fourthChild.PlayGame());
                    break;
                case Adult fourthAdult:
                    Console.WriteLine(fourthAdult.GoToWork());
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("");

        }
    }
}
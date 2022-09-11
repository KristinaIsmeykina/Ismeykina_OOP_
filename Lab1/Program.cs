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
            PersonList[] lists =
             {
                list1
            };
           
            Console.WriteLine("Creating a list of 7 people");
            var rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                int genderType = rnd.Next(0, 2);
                bool marriageStatus = Convert.ToBoolean(rnd.Next(0,2));
                if (genderType == 0)
                {

                    list1.Add(Adult.GetPair(maleNames, femaleNames, surnames, workplaces, marriageStatus, genderType, rnd));
                }
                else if (genderType == 1)
                {
                    list1.Add(Adult.GetPair(femaleNames, maleNames, surnames, workplaces, marriageStatus, genderType, rnd));
                }


            }
        
            for (int i = 0; i < list1.Length(); i++)
            {
                Console.WriteLine(list1.GetPersonByIndex(i).Info());
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
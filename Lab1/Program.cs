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
            int adultsNumber = rnd.Next(1, 3);
            for (int i = 0; i < adultsNumber; i++)
            {
                var pairList = Adult.GetRandomAdult(names, surnames, workplaces);
                for (int j = 0; j < pairList.Count; j++)
                {
                    list1.Add(pairList);
                }
      
            }
            Show(lists);
            Console.ReadKey();
            Console.WriteLine("");
        }
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child:Person
    {
        
        /// <summary>
        /// Минимальный возраст для ребенка
        /// </summary>
        private const int _minAge = 1;

        /// <summary>
        /// Максимальный возраст для ребенка
        /// </summary>
        private const int _maxAge = 18;

        /// <summary>
        /// Переопределенное свойсто получения минимального возраста ребенка
        /// </summary>
        protected override int MinAge
        {
            get => _minAge;
        }

        /// <summary>
        /// Переопределенное свойсто получения максимального возраста ребенка
        /// </summary>
        protected override int MaxAge
        {
            get => _maxAge;
        }

        /// <summary>
        /// Первый родитель
        /// </summary>
        public string FirstParent { get; set; }

        /// <summary>
        /// Второй родитель
        /// </summary>
        public string SecondParent { get; set; }

        /// <summary>
        /// Учреждение для ребенка
        /// </summary>
        public string Facility { get; set; }

        /// <summary>
        /// Конструктор для класса Child
        /// </summary>
        /// <param name="facility"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Child( string name, string surname, int age,  GenderPerson gender, string facility, string firstParent = null, string secondParent = null)
            : base(name, surname, age, gender)
        {
            FirstParent = firstParent;
            SecondParent = secondParent;
            Facility = facility;
        }

        /// <summary>
        /// Создание рандомного ребенка
        /// </summary>
        /// <param name="names"></param>
        /// <param name="surnames"></param>
        /// <param name="facilities"></param>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static Child GetRandomChild(List<string> names, List<string> surnames, List<string> facilities, Random rnd)
        {
            var person = new Child(
                                  names[rnd.Next(0, names.Count() - 1)],
                                  surnames[rnd.Next(0, surnames.Count() - 1)],
                                  rnd.Next(_minAge, _maxAge),
                                  (GenderPerson)rnd.Next(0, 2),
                                 facilities[rnd.Next(0, facilities.Count() - 1)]);
                                 
            return person;
        }

        /// <summary>
        /// Присваивает родителей для ребенка
        /// </summary>
        /// <param name="names"></param>
        /// <param name="surnames"></param>
        /// <param name="facilities"></param>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static Child GetChildWithParrent(List<string> names, List<string> surnames, List<string> facilities, Random rnd)
        {
            Child person = GetRandomChild(names, surnames, facilities, rnd);
            int numberAdult = rnd.Next(0, 3);
            switch(numberAdult)
            {
                case 1:
                    string name = names[rnd.Next(0, names.Count() - 1)];
                    person.FirstParent = $"{name} {person.Surname}";
                    break;
                case 2:
                    string name1 = names[rnd.Next(0, names.Count() - 1)];
                    string name2 = names[rnd.Next(0, names.Count() - 1)];
                    person.FirstParent = $"{name1} {person.Surname}";
                    person.SecondParent = $"{name2} {person.Surname}";
                    break;

            }
            return person;

        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            string addition = null;
            if (SecondParent == null && FirstParent == null)
            {
                addition = "Null";
            }
            else if (FirstParent == null || SecondParent == null)
            {
                addition = $"First parent: {FirstParent}";
            }
            else
            {
                addition = $"First parent: {FirstParent}, Second parent: {SecondParent}";
            }

            return $"{base.InfoPerson}, Facility: {Facility}, Parents: " + addition;
        }
    }
}

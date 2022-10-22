using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Child
    /// </summary>
    public class Child:PersonBase
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
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="age">возраст</param>
        /// <param name="gender">пол</param>
        /// <param name="facility">учреждение</param>
        /// <param name="firstParent">первый родитель</param>
        /// <param name="secondParent">втрой родитель</param>
        //TODO: RSDN /сделано
        public Child( string name, string surname, int age,  
                      GenderPerson gender, string facility,
                      string firstParent = null, string secondParent = null)
                      : base(name, surname, age, gender)
        {
            FirstParent = firstParent;
            SecondParent = secondParent;
            Facility = facility;
        }
       



        /// <summary>
        /// Создание рандомного объекта класса Child
        /// </summary>
        /// <param name="names">список имен</param>
        /// <param name="surnames">список фамилий</param>
        /// <param name="facilities">список учреждений</param>
        /// <param name="gender">пол</param>
        /// <param name="random">объект класса Random</param>
        /// <returns>объект класса Child</returns>
        public static Child GetRandomChild(List<string> names, 
                                           List<string> surnames,
                                           List<string> facilities,
                                           int gender, Random random)
        {
            var person = new Child(
                                  names[random.Next(0, names.Count() - 1)],
                                  surnames[random.Next(0, surnames.Count() - 1)],
                                  random.Next(_minAge, _maxAge),
                                  (GenderPerson)gender,
                                  facilities[random.Next(0, facilities.Count() - 1)]);
                                 
            return person;
        }

        //TODO: RSDN
        /// <summary>
        /// Присваивает ребенку родителя
        /// </summary>
        /// <param name="names">список имен</param>
        /// <param name="names2">список имен</param>
        /// <param name="surnames">списокфамилий</param>
        /// <param name="facilities">список учреждений</param>
        /// <param name="gender">пол</param>
        /// <param name="random">объект класса рандом</param>
        /// <returns>объект класса Child</returns>
        public static Child GetChildWithParrent(List<string> names, List<string> names2, 
                                                List<string> surnames, List<string> facilities,
                                                int gender, Random random)
        {
            Child person = GetRandomChild(names, surnames, facilities,gender, random);
            int numberAdult = random.Next(0, 3);
            switch(numberAdult)
            {
                case 1:
                    string name = names[random.Next(0, names.Count() - 1)];
                    person.FirstParent = $"{name} {person.Surname}";
                    break;
                case 2:
                    string name1 = names[random.Next(0, names.Count() - 1)];
                    string name2 = names2[random.Next(0, names2.Count() - 1)];
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

        /// <summary>
        /// Уникальный метод для Child
        /// </summary>
        /// <returns></returns>
        public string PlayGame()
        {
            return $"{this.Name} likes to play chess";
        }
    }
}

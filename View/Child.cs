using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child : Person
    {
        //private string _firstParent;
        //private string _secondParent;

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
        protected override int MaxAge
        {
            get => _maxAge;
        }
        public string FirstParent { get; set; }
        public string SecondParent { get; set; }
        public string Facility { get; set; }

        /// <summary>
        /// Конструктор для 
        /// </summary>
        /// <param name="facility"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Child(string firstParent = null, string secondParent = null, string facility, string name, string surname, int age, GenderPerson gender)
            : base(name, surname, age, gender)
        {
            FirstParent = firstParent;
            SecondParent = secondParent;
            Facility = facility;
        }

        public static Child GetRandomChild(List<string> names, List<string> surnames,List<string> facilities)
        {
            var rnd = new Random();
            var person = new Child(rnd.Next(1000, 9999).ToString(),
                                  facilities[rnd.Next(0, facilities.Count() - 1)],

                                  names[rnd.Next(0, names.Count() - 1)],
                                  surnames[rnd.Next(0, surnames.Count() - 1)],
                                  rnd.Next(_minAge, _maxAge),
                                  (GenderPerson)rnd.Next(0, 2));
            return person;
        }
        public override string Info() => $"{base.InfoPerson}" +
            $"Первый родитель - {FirstParent} Второй родитель - {SecondParent}";
    }
}

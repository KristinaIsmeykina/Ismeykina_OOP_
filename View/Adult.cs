using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adult : Person
    {
        /// <summary>
        /// Паспортные данные
        /// </summary>
        private string _passport;

        /// <summary>
        /// Состояние в браке ( True - в браке False - не в браке)  
        /// </summary>
        private bool _marriageStatus;

        /// <summary>
        /// Партнер 
        /// </summary>
        private string _marriagePartner;

        /// <summary>
        /// Название места работы
        /// </summary>
        private string _workplace;

        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        private const int _minAge = 18;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        private const int _maxAge = 120;
        protected override int MinAge
        {
            get => _minAge;
        }

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        protected override int MaxAge
        {
            get => _maxAge;
        }

        /// <summary>
        /// Паспорт
        /// </summary>
        public string Passport
        {
            get => _passport;

            set => _passport = value;
        }

        /// <summary>
        /// Состояние в браке
        /// </summary>
        public bool MarriageStatus
        {
            get => _marriageStatus;

            set => _marriageStatus = value;
        }

        /// <summary>
        /// Партнер 
        /// </summary>
        public string MarriagePartner
        {
            get => _marriagePartner;
            set
            {
                if (_marriageStatus == true)
                {
                    _marriagePartner = value;

                }
                else
                {
                    //throw new Exception("not married");
                    Console.WriteLine("not maried");
                }
            }
        }

        /// <summary>
        /// Место работы 
        /// </summary>
        public string Workplace
        {
            get => _workplace;

            set => _workplace = value;
        }

        /// <summary>
        /// Конструктор класса Adult
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="passport"></param>
        /// <param name="workplace"></param>
        /// <param name="marriageStatus"></param>
        /// <param name="marriagePartner"></param>
        public Adult(string name, string surname, int age, GenderPerson gender, string passport, string workplace, bool marriageStatus,
                string marriagePartner=null)
                : base(name, surname, age, gender)
        {
            Passport = passport;
            Workplace = workplace;
            MarriageStatus = marriageStatus;
            MarriagePartner = marriagePartner;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            string addition = null;
            if (MarriageStatus == true)
            {
                addition = $", Marriage partner: {MarriagePartner}";
            }
            return $"{base.InfoPerson}, Passport: {Passport}, " +
                   $"Workplace: {Workplace}, Marriage status: {MarriageStatus} {addition}";
        }

        /// <summary>
        /// Создает рандомного взрослого
        /// </summary>
        /// <param name="names"></param>
        /// <param name="surnames"></param>
        /// <param name="workplaces"></param>
        /// <param name="marriageStatus"></param>
        /// <param name="x"></param>
        /// <param name="rnd"></param>
        /// <returns></returns>
        public static Adult GetRandomAdult(List<string> names, List<string> surnames, List<string> workplaces, bool marriageStatus, int x, Random rnd)
        {
            
            var person = new Adult(
                                   names[rnd.Next(0, names.Count() - 1)],
                                   surnames[rnd.Next(0, surnames.Count() - 1)],
                                   rnd.Next(_minAge, _maxAge),
                                   (GenderPerson)x,
                                   rnd.Next(1000, 5000).ToString(),
                                   workplaces[rnd.Next(0, workplaces.Count() - 1)],
                                   marriageStatus );
            return person;
        }
      
        /// <summary>
        /// Создает пару для взрослого
        /// </summary>
        /// <param name="names"></param>
        /// <param name="names2"></param>
        /// <param name="surnames"></param>
        /// <param name="workplaces"></param>
        /// <param name="marrigeStatus"></param>
        /// <param name="genderType"></param>
        /// <param name="rnd"></param>
        /// <returns>Взрослого человека</returns>
        public static Adult GetPair(List<string> names, List<string> names2, List<string> surnames, List<string> workplaces, bool marrigeStatus, int genderType, Random rnd)
        {
            
            Adult person = GetRandomAdult(names, surnames, workplaces, marrigeStatus, genderType, rnd);
            if (marrigeStatus==true)
            {
                Adult person2 = GetRandomAdult(names2, surnames, workplaces, marrigeStatus, genderType, rnd);
                person.MarriagePartner = $"{person2.Name} {person.Surname}";
            }
            return person;
        }

        /// <summary>
        /// Уникальный метод для взрослого
        /// </summary>
        /// <returns></returns>
        public string GoToWork()
        {
            return $"{this.Name} went to work to {this.Workplace}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Adult
    /// </summary>
    public class Adult : PersonBase
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

        /// <summary>
        /// Переопредление свойства минимальный возраст взрослого
        /// </summary>
        protected override int MinAge
        {
            get => _minAge;
        }

        /// <summary>
        /// Переопредление свойства максимальный возраст взрослого
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
            set => _marriagePartner = value;
        }

        /// <summary>
        /// Место работы 
        /// </summary>
        public string Workplace
        {
            get => _workplace;

            set => _workplace = value;
        }

        //TODO: RSDN /сделано
        /// <summary>
        /// Конструктор класса Adult
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="age">возраст</param>
        /// <param name="gender">пол</param>
        /// <param name="passport">паспорт</param>
        /// <param name="workplace">место работы</param>
        /// <param name="marriageStatus">состояние в браке</param>
        /// <param name="marriagePartner">партнер</param>
        public Adult(string name, string surname, int age, GenderPerson gender,
                     string passport, string workplace, bool marriageStatus,
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
                   $"Workplace: {Workplace}," +
                   $" Marriage status: {MarriageStatus} {addition}";
        }

        /// <summary>
        /// Создает рандомного взрослого
        /// </summary>
        /// <param name="names">список имен</param>
        /// <param name="surnames">список фамилий</param>
        /// <param name="workplaces">список учреждений</param>
        /// <param name="marriageStatus">состояние в браке</param>
        /// <param name="genderType">пол</param>
        /// <param name="random">объект класса рандом</param>
        /// <returns>объект класса Adult</returns>
        //TODO: RSDN /сделано
        public static Adult GetRandomAdult(List<string> names, List<string> surnames,
                                           List<string> workplaces, bool marriageStatus,
                                           int genderType, Random random)
        {
            
            var person = new Adult(
                                   names[random.Next(0, names.Count() - 1)],
                                   surnames[random.Next(0, surnames.Count() - 1)],
                                   random.Next(_minAge, _maxAge),
                                   (GenderPerson)genderType,
                                   random.Next(1000, 5000).ToString(),
                                   workplaces[random.Next(0, workplaces.Count() - 1)],
                                   marriageStatus );
            return person;
        }

        /// <summary>
        /// Создает пару для взрослого
        /// </summary>
        /// <param name="names">список имен</param>
        /// <param name="names2">список имен</param>
        /// <param name="surnames">фамилия</param>
        /// <param name="workplaces">место работы</param>
        /// <param name="marrigeStatus">статус в браке</param>
        /// <param name="genderType">пол</param>
        /// <param name="random">объект класса </param>
        /// <returns>Объект класса Adult</returns>
        //TODO: RSDN
        public static Adult GetPair(List<string> names, List<string> names2, 
                                    List<string> surnames,  List<string> workplaces, 
                                    bool marrigeStatus, int genderType, Random random)
        {
            
            Adult person = GetRandomAdult(names, surnames, workplaces,
                                          marrigeStatus, genderType, random);
            
            if (marrigeStatus)
            {
                Adult person2 = GetRandomAdult(names2, surnames, workplaces,
                                               marrigeStatus, genderType, random);
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

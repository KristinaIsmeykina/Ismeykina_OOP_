using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Adult : Person
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
        /// Свойство паспортные данные
        /// </summary>
        public string Passport
        {
            get => _passport;
            set => _passport = value;
        }
        /// <summary>
        /// Свойство состояние в браке
        /// </summary>
        public bool MarriageStatus
        {
            get => _marriageStatus;
            set => _marriageStatus = value;
        }
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
                    throw new Exception("not married");
                }
            }
        }

        public string Workplace
        {
            get => _workplace;
            set => _workplace = value;
        }

        /// <summary>
        /// Констурктор
        /// </summary>
        /// <param name="passport"></param>
        /// <param name="workplace"></param>
        /// <param name="marriageStatus"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Adult(string passport, string workplace, bool marriageStatus,
            string name, string surname, int age, GenderPerson gender)
            : base(name, surname, age, gender)
        {
            Passport = passport;
            Workplace = workplace;
            MarriageStatus = marriageStatus;
        }
        public override string Info()
        {
            string marriagePartner = null;
            if (MarriageStatus ==true)
            {
                marriagePartner = $"{}";
            }
        }
        public static Adult GetRandomAdult(List<string> names, List<string> surnames, List<string> workplaces, bool marriageStatus)
        {
            var person = new Adult(rnd.Next(1000, 9999).ToString(),
                                  workplaces[rnd.Next(0, workplaces.Count() - 1)],
                                  marriageStatus,

                                  names[rnd.Next(0, names.Count() - 1)],
                                  surnames[rnd.Next(0, surnames.Count() - 1)],
                                  rnd.Next(_minAge, _maxAge),
                                  (Gender)rnd.Next(0, 2));
            return person;
        }


    }
}

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

        public string Workplace
        {
            get => _workplace;
            set => _workplace = value;
        }



    }
}

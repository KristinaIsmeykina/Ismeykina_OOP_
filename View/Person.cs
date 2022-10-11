using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    //TODO: RSDN
    /// <summary>
    /// Класс Person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Свойство получения минимального возраста человека
        /// </summary>
        protected abstract int MinAge { get; }

        /// <summary>
        /// Свойство получения максимального возраста человека
        /// </summary>
        protected abstract int MaxAge { get; }

        /// <summary>
        /// Имя персоны
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия персоны
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст персоны
        /// </summary>
        private int _age;

        /// <summary>
        /// Свойство для получения и установки имя персоны
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = CheckValue(value);
        }

        /// <summary>
        /// Свойство для получения и установки фамилии персоны
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = CheckValue(value);
        }

        /// <summary>
        /// Язык
        /// </summary>
        private string _lang;

        /// <summary>
        /// Возвращает правильную строку
        /// </summary>
        /// <param name="inputValue">переданная строка</param>
        /// <returns></returns>
        private string CheckValue(string inputValue)
        {
            if (String.IsNullOrEmpty(inputValue))
            {
                throw new ArgumentException("Value must not be empty");
            }
            if (ValidName(inputValue) == "Other")
            {
                throw new ArgumentException("Use only latin or cyrilic");

            }
            if (_name != null && ValidName(inputValue)!= ValidName(_name))
            {
                throw new ArgumentException("Name and Surname must be in the same language");
            }
            
            return ChangeFirstLetter(inputValue); 
            
        }
        
        /// <summary>
        /// Свойство для получения и установки возраста персоны
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException($"Age must be in range:"
                        + $" {MinAge} - {MaxAge}");
                }
                _age = value;
            }
        }
        /// <summary>
        /// Свойство для получения и установки пола персоны
        /// </summary>
        public GenderPerson Gender { get; set; }

        //TODO: Не имеет смысл делать public.
        /// <summary>
        /// Коструктор класса Person
        /// </summary>
        /// <param name="name"> Имя</param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        /// <param name="gender"> Пол </param>
        public Person(string name, string surname, int age, GenderPerson gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        //TODO: Не имеет смысл делать public.
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() : this("Unknown", "Unknown", 1, GenderPerson.Unknown)
        { }

        /// <summary>
        /// Проверяет, содержит ли строка только русские или 
        /// только английские символы
        /// </summary>
        /// <param name="input">строка для проверки</param>
        /// <returns>строковую переменную</returns>
        private string ValidName(string input)
        {
            Regex regexRUS = new Regex(@"^[А-Яа-я]+\-?([А-Яа-я]+)?$");
            Regex regexENG = new Regex(@"^[A-Za-z]+\-?([A-Za-z]+)?$");
            //BUG:
            if (regexRUS.IsMatch(input))
            {
                this._lang = "Rus";
            }

            if (regexENG.IsMatch(input))
            {
                this._lang = "Eng";
            }
            else
            {
                this._lang = "Other";
            }
            return _lang;
        }

        /// <summary>
        /// Изменяет первую букву на заглавную
        /// </summary>
        /// <param name="input"> строка для изменения</param>
        /// <returns></returns>
        public string ChangeFirstLetter(string input)
        {
            return input.Substring(0, 1).ToUpper() + 
                input.Substring(1, input.Length - 1).ToLower();
        }

        /// <summary>
        /// Получает информацию о человеке
        /// </summary>
        /// <returns></returns>
        public abstract string Info();

        /// <summary>
        /// Получает информацию о человеке
        /// </summary>
        public string InfoPerson => $"Name: {Name}, Surname: {Surname}, Age: {Age}, Gender: {Gender}";
    }
}
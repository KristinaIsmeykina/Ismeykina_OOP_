using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    //TODO: XML
    public class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = CheckValue(value);
        }

        public string Surname
        {
            get => _surname;
            set => _surname = CheckValue(value);
        }


        private string CheckValue(string inputValue)
        {
            if (String.IsNullOrEmpty(inputValue))
            {
                throw new ArgumentException("Значение не может быть пустым");
            }

            if (!ValidName(inputValue))
            {
                throw new ArgumentException("Значение должно содержать только" +
                                            " латинские или только аншлийские символы");
            }
            return !CheckFirstLetter(inputValue) 
                ? ChangeFirstLetter(inputValue) 
                : inputValue;
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                //TODO: RSDN
                const int MinAge = 1;
                const int MaxAge = 120;
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException($"Значение должно находится в диапазоне:" +
                        $" {MinAge} - {MaxAge}");
                }
                _age = value;
            }
        }

        public GenderPerson Gender { get; set; }

        /// <summary>
        /// Создает экземпляр класса Person
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


        public Person() : this("", "", 0, GenderPerson.Unknown)
        { }

        /// <summary>
        /// Проверяет, содержит ли строка только русские или 
        /// только английские символы
        /// </summary>
        /// <param name="input">строка для проверки</param>
        /// <returns></returns>
        public static bool ValidName(string input)
        {
            Regex regexRUS = new Regex(@"^[А-Яа-я]+\-?([А-Яа-я]+)?$");
            Regex regexENG = new Regex(@"^[A-Za-z]+\-?([A-Za-z]+)?$");
            if (regexRUS.IsMatch(input))
            {
                return true;
            }
            if (regexENG.IsMatch(input))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Проверяет, является ли первая буква заглавной
        /// </summary>
        /// <param name="input"> строка для проверки</param>
        /// <returns></returns>
        public static bool CheckFirstLetter(string input)
        {
            Regex regexFirstLetter = new Regex(@"^[А-Я]|[A-Z]$");
            if (regexFirstLetter.IsMatch(input.Substring(0, 1)))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Изменяет первую букву на заглавную
        /// </summary>
        /// <param name="input"> строка для изменения</param>
        /// <returns></returns>
        public string ChangeFirstLetter(string input)
        {
            //TODO: RSDN
            return input.Substring(0, 1).ToUpper() + input.Substring(1, input.Length - 1).ToLower();
        }

        /// <summary>
        /// Генерирует человека, использую имена и фамилии из списка
        /// </summary>
        /// <param name="names"> Список рандомных имен</param>
        /// <param name="surnames">Список рандомных фамилий</param>
        /// <returns></returns>
        public static Person GetRandomPerson(List<string> names, List<string> surnames)
        {
            Random rnd = new Random();
            //TODO: RSDN
            Person person = new Person(names[rnd.Next(0, names.Count() - 1)],
                //TODO: to const
                surnames[rnd.Next(0, surnames.Count() - 1)], rnd.Next(1, 120), GenderPerson.Male);
            return person;
        }

        /// <summary>
        /// Получает информацию о человеке
        /// </summary>
        public string Info => $"{Name} {Surname} {Age} {Gender}";
    }
}
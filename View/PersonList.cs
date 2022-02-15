using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PersonList
    {
        private Person[] _personList = new Person[0];

        /// <summary>
        /// Добавляет человека в список 
        /// </summary>
        /// <param name="person"> экземпляр</param>
        public void Add(Person person)
        {
            int count = _personList.Length;
            Array.Resize(ref _personList, count + 1);
            _personList[count] = person;
        }

        /// <summary>
        /// Удаляет последний элемент списка
        /// </summary>
        public void DeleteLast()
        {
            int count = _personList.Length;
            Array.Resize(ref _personList, count - 1);
        }

        /// <summary>
        /// Удаляет человека из списка по индексу
        /// </summary>
        /// <param name="index"> индекс человека</param>
        public void DeletePersonByIndex(int index)
        {
            int count = _personList.Length;
            Person[] tmpPersonList = _personList;
            int tmpIndex = 0;
            _personList = new Person[count - 1];
            for (int i = 0; i < count; i++)
            {
                if (i != count)
                {
                    _personList[tmpIndex] = tmpPersonList[i];
                    tmpIndex++;
                }
            }
        }

        /// <summary>
        /// Получает индекс человека
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public int GetIndexOfPerson(Person person)
        {
            return Array.IndexOf(_personList, person);
        }

        /// <summary>
        /// Получает человека по индексу
        /// </summary>
        /// <param name="index"> индекс человека</param>
        /// <returns></returns>
        public Person GetPersonByIndex(int index)
        {
            return _personList[index];
        }

        /// <summary>
        /// Очищает список
        /// </summary>
        public void Clear()
        {
            Array.Resize(ref _personList, 0);
        }

        /// <summary>
        /// Находит длину списка
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return _personList.Length;
        }
    }
}

using System;

namespace Model
{
    /// <summary>
    /// Класс: список Person
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список из персон
        /// </summary>
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
            if (_personList.Length>0)
            {
                int count = _personList.Length;
                Array.Resize(ref _personList, count - 1);
            }
            else
            {
                throw new Exception("Список пуст");
            }
        }

        /// <summary>
        /// Удаляет человека из списка по индексу
        /// </summary>
        /// <param name="index"> индекс человека</param>
        public void DeletePersonByIndex(int index)
        {
           
            int count = _personList.Length;

            CheckValidIndex(index);
            Person[] tmpPersonList = _personList;
            int tmpIndex = 0;
            _personList = new Person[count - 1];
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    _personList[tmpIndex] = tmpPersonList[i];
                    tmpIndex++;
                }
            }
        }

       /// <summary>
       /// Проверяет корректность введенного индекса персоны в списке
       /// </summary>
       /// <param name="index"></param>
        public void CheckValidIndex(int index)
        {
            int count = _personList.Length;

            if ((index + 1 > count) || (index < 0))
            {
                throw new Exception("Такого индекса нет");
            }
        }

        /// <summary>
        /// Получает индекс человека
        /// </summary>
        /// <param name="person"></param>
        /// <returns>индекс</returns>
        public int GetIndexOfPerson(Person person)
        {
            return Array.IndexOf(_personList, person);
        }

        /// <summary>
        /// Получает человека по индексу
        /// </summary>
        /// <param name="index"> индекс человека</param>
        /// <returns> персона</returns>
        public Person GetPersonByIndex(int index)
        {
            CheckValidIndex(index);
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
        /// <returns> длина списка</returns>
        public int Length()
        {
            return _personList.Length;
        }
    }
}
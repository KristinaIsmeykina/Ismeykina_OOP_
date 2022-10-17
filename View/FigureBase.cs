using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //TODO: RSDN
    public abstract class FigureBase
    {
        /// <summary>
        /// Проверяет является ли значение положительным
        /// </summary>
        /// <param name="value">Входное значение</param>
        protected static void CheckValue(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"The value must be greater than 0");
            }
        }

        /// <summary>
        /// Метод расчитывающий объем
        /// </summary>
        /// <returns>Объем</returns>
        public abstract double GetVolume();

        /// <summary>
        /// Свойство - информация об объекте
        /// </summary>
        public abstract string Info { get; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{

    /// <summary>
    /// Абстрактный класс Фигура
    ///</summary>
    [XmlInclude(typeof(Sphere))]
    [XmlInclude(typeof(Pyramid))]
    [XmlInclude(typeof(Parallelepiped))]
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
            if (double.IsNaN(value))
            {
                throw new ArgumentException(
                   $"The value must not be NaN");
            }
        }

        /// <summary>
        /// Свойство - Объем
        /// </summary>
        /// <returns>Объем</returns>
        public abstract double Volume { get; }

        /// <summary>
        /// Свойство - информация об объекте
        /// </summary>
        public abstract string Info { get; }

        /// <summary>
        /// Получает рандомное число из диапазона
        /// </summary>
        /// <param name="firstNumber"> левая граница</param>
        /// <param name="secondNumber">правая граница</param>
        /// <returns> рандомное число</returns>
        protected static double GetValue(int firstNumber, int secondNumber)
        {
            var random = new Random();
            double result = Math.Round(random.NextDouble() * secondNumber + firstNumber, 3);
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Pyramid
    /// </summary>
    public class Pyramid : FigureBase
    {

        /// <summary>
        /// Высота пирамиды
        /// </summary>
        private double _height;

        /// <summary>
        /// Длина первой стороны пирамиды
        /// </summary>
        private double _firstSide;

        /// <summary>
        /// Длина второй стороны пирамиды
        /// </summary>
        private double _secondSide;

        /// <summary>
        /// Угол между первой и второй сторонной пирамиды
        /// </summary>
        private double _angle;

        /// <summary>
        /// Максимальный угол
        /// </summary>
        private const int MaxAngle = 180;

        /// <summary>
        /// Минимальный угол
        /// </summary>
        private const int MinAngle = 0;

        /// <summary>
        /// Свойство -  высота пирамиды
        /// </summary>
        private double Height
        {
            get => _height;
            set
            {
                CheckValue(value);
                _height = value;
            }
        }

        /// <summary>
        /// Свойство - Длина первой стороны пирамиды
        /// </summary>
        private double FirstSide
        {
            get => _firstSide;
            set
            {
                CheckValue(value);
                _firstSide = value;
            }
        }

        /// <summary>
        /// Свойство -  длина второй высоты пирамиды
        /// </summary>
        private double SecondSide
        {
            get => _secondSide;
            set
            {
                CheckValue(value);
                _secondSide = value;
            }
        }

        /// <summary>
        /// Свойство - Угол
        /// </summary>
        private double Angle
        {
            get => _angle;
            set
            {
                if (value <= MinAngle || value >= MaxAngle)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{value} must be greater than {MinAngle} " +
                                $"or less than {MaxAngle}");
                }
                _angle = value;
            }
        }
        /// <summary>
        /// Минимальное число углов основания пирамиды
        /// </summary>
        private const int MinCornersNumber = 3;

        /// <summary>
        /// Количество углов основания
        /// </summary>
        private int _numberOfCorners;

        /// <summary>
        /// Свойство - количество углов основания
        /// </summary>
        private int NumberOfCorners
        {
            get => _numberOfCorners;
            set
            {
                if (value < MinCornersNumber)
                {
                    throw new ArgumentOutOfRangeException(
                        $"The value must be greater than {MinCornersNumber}");
                }

                _numberOfCorners = value;
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override double GetVolume()
        {
            int added = 1;
            if (NumberOfCorners == 3)
            {
                added = 2;
            }
            double baseArea = FirstSide * SecondSide * Math.Sin(Angle * Math.PI / 180) / added;
            return Math.Round(baseArea * Height,3);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string Info => $"Pyramid Corners:{NumberOfCorners}; " +
                                     $"H: {Height}; " +
                                     $"L1: {FirstSide}; " +
                                     $"L2: {SecondSide}; " +
                                     $"Angle: {Angle}";

        /// <summary>
        /// Конструктор для Pyramid
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="numberOfCorners">количесво углов у осования</param>
        /// <param name="firstSide">длина первой стороны</param>
        /// <param name="secondSide">длина второй стороны</param>
        /// <param name="angle">угол между второй и первой стороной</param>
        public Pyramid(double height, 
                       int numberOfCorners,
                       double firstSide,
                       double secondSide,
                       double angle)
        {
            Height = height;
            NumberOfCorners = numberOfCorners;
            FirstSide = firstSide;
            SecondSide = secondSide;
            Angle = angle;

        }

        /// <summary>
        /// Генерация пирамиды
        /// </summary>
        /// <returns></returns>
        public static Pyramid GetRandomPyramid()
        {
            const int maxLength = 100;
            const int minLength = 0;
            const int maxCornersNumbers = 4;
            var random = new Random();
            //TODO: дублирование получения числа в диапазоне/сделано
            var pyramid = new Pyramid(GetValue(minLength, maxLength),
                                      random.Next(MinCornersNumber, maxCornersNumbers + 1),
                                      GetValue(minLength, maxLength),
                                      GetValue(minLength, maxLength),
                                      GetValue(MinAngle, MaxAngle));
            return pyramid;
        }
    }    
}

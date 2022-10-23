using System;

namespace Model
{
    //TODO: RSDN/сделано
    /// <summary>
    /// Класс Parallelepiped
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Высота
        /// </summary>
        private double _height;

        /// <summary>
        /// Длина первой стороны параллелепипида
        /// </summary>
        private double _firstSide;

        /// <summary>
        /// Длина второй стороны параллелепипида
        /// </summary>
        private double _secondSide;

        /// <summary>
        /// Угол между первой и второй сторонной параллелепипеда
        /// </summary>
        private double _angle;

        //TODO: XML/сделано
        /// <summary>
        /// Максимальный угол
        /// </summary>
        private const int MaxAngle = 180;

        /// <summary>
        /// Минимальный угол
        /// </summary>
        private const int MinAngle = 0;
        
        //TODO: XML/сделано

        /// <summary>
        /// Высота
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
        /// Свойство - первоя сторона
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
        /// Свойство - вторая сторона
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
        /// Свойство -  угол
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
        /// Конструктор паралелепипида
        /// </summary>
        /// <param name="height"></param>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="angle"></param>
        public Parallelepiped(double height,
                              double firstSide,
                              double secondSide,
                              double angle)
        {
            Height = height;
            FirstSide = firstSide;
            SecondSide = secondSide;
            Angle = angle;

        }

        /// <summary>
        /// Конструктор паралелепипида по умолчанию
        /// </summary>
        public Parallelepiped() { }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <returns></returns>
        public override double GetVolume()
        {
            double baseArea = FirstSide * SecondSide * Math.Sin(Angle * Math.PI / 180);
            return Math.Round(baseArea * Height,3);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public override string Info => $"Parallelepiped H: {Height}; " +
                                       $"L1: {FirstSide}; " +
                                       $"L2: {SecondSide}; " +
                                       $"Angle: {Angle}";


        /// <summary>
        /// Генерация паралелепипида
        /// </summary>
        /// <returns></returns>
        public static Parallelepiped GetRandomParallelepiped()
        {
            const int maxLength = 100;
            const int minLength = 0;
            //TODO: зачем?
            var parallelepiped = new Parallelepiped(GetValue(minLength, maxLength),
                                                    GetValue(minLength, maxLength),
                                                    GetValue(minLength, maxLength),
                                                    GetValue(MinAngle, MaxAngle));
            return parallelepiped;
        }
    }
}
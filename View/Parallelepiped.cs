using System;

namespace Model
{
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
        private const int MaxAngle = 180;
        private const int MinAngle = 0;
        private double Height
        {
            get => _height;
            set
            {
                CheckValue(value);
                _height = value;
            }
        }
        private double FirstSide
        {
            get => _firstSide;
            set
            {
                CheckValue(value);
                _firstSide = value;
            }
        }
        private double SecondSide
        {
            get => _secondSide;
            set
            {
                CheckValue(value);
                _secondSide = value;
            }
        }
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

        protected override double GetVolume()
        {
            double baseArea = FirstSide * SecondSide * Math.Sin(Angle * Math.PI / 180);
            return baseArea * Height;
        }
        protected override string Info => $"Parallelepiped H: {Height}; " +
                                       $"L1: {FirstSide}; " +
                                       $"L2: {SecondSide}; " +
                                       $"Angle: {Angle}";
        public static Parallelepiped GetRandomParallelepiped()
        {
            var rnd = new Random();
            var parallelepiped = new Parallelepiped(rnd.Next(0, 1000) / 1.00,
                rnd.Next(0, 1000) / 1.00,
                rnd.Next(0, 1000) / 1.00,
                rnd.Next(MinAngle, MaxAngle) / 1.00);
            return parallelepiped;
        }
    }
}
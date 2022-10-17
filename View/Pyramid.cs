using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pyramid: FigureBase
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
        /// <summary>
        /// Max number of corners of the base of the pyramid
        /// </summary>
        private const int MinCornersNumber = 3;

        private int _numberOfCorners;
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
        protected override double GetVolume()
        {
            int added = 1;
            if (NumberOfCorners==3)
            {
                added = 2;
            }
            double baseArea = FirstSide * SecondSide * Math.Sin(Angle * Math.PI / 180)/added;
            return baseArea * Height;
        }
       
        protected override string Info => $"Pyramid H: {Height}; " +
                                     $"L1: {FirstSide}; " +
                                     $"L2: {SecondSide}; " +
                                     $"Angle: {Angle}";

        public Pyramid(double height,
                             double firstSide,
                             double secondSide,
                             double angle)
        {
            Height = height;
            FirstSide = firstSide;
            SecondSide = secondSide;
            Angle = angle;

        }
        public static Pyramid GetRandomPyramid()
        {
            var rnd = new Random();
            var pyramid = new Pyramid(rnd.Next(0, 1000) / 1.00,
                rnd.Next(0, 1000) / 1.00,
                rnd.Next(0, 1000) / 1.00,
                rnd.Next(MinAngle, MaxAngle) / 1.00);
            return pyramid;
        }
         
}

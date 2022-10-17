using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parallelepiped:FigureBase
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
        private const double MaxAngle = 180;
        private const double MinAngle = 0;
        private double Height
        {
            get => _height;
            set => _height = CheckValue(value);
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
            
        }

        public override double GetVolume() => Area * _height;
    }
}

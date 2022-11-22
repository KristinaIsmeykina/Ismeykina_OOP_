using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Sphere
    /// </summary>
    public class Sphere: FigureBase
    {
        /// <summary>
        /// Радиус сферы
        /// </summary>
        private double _radius;

        /// <summary>
        /// Свйоство - радиус сферы
        /// </summary>
        private double Radius
        {
            get => _radius;
            set
            {
                CheckValue(value);
                _radius = value;
            }
        }

        ///  <inheritdoc />
        public override double GetVolume()
        {
            //TODO: Теряется точность ++.
            return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
        }

        /// <inheritdoc />
        public override string Info => $"Sphere R: {Radius}";

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Создание сферы
        /// </summary>
        /// <returns></returns>
        public static Sphere GetRandomSphere()
        {
            const int maxLength = 100;
            const int minLength = 0;
            var sphere = new Sphere(GetValue(minLength, maxLength)); 
            return sphere;
        }
    }
}

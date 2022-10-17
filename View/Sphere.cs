using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sphere: FigureBase
    {
        /// <summary>
        /// Sphere radius
        /// </summary>
        private double _radius;

        /// <summary>
        /// Sphere radius's property
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

        /// <summary>
        ///  <inheritdoc />
        /// </summary>
        /// <returns></returns>
        protected override double GetVolume()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        protected override string Info => $"Sphere R: {Radius}";

        /// <summary>
        /// Sphere's instance constructor
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            Radius = radius;
        }

        public static Sphere GetRandomSphere()
        {
            var rnd = new Random();
            var sphere = new Sphere(rnd.Next(0,100)/1.00); 
            return sphere;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace View
{
    //TODO: RSDN
    public class Program
    {
        public static void Main(string[] args)
        {
         

            var figureList = new List<FigureBase>();
            var rnd = new Random();

            for (var i = 0; i < 10; i++)
            {
                var option = rnd.Next(3);
                switch (option)
                {
                    case 0:
                        figureList.Add(Sphere.GetRandomSphere());
                        break;
                    case 1:
                        figureList.Add(Pyramid.GetRandomPyramid());
                        break;
                    case 2:
                        figureList.Add(Parallelepiped.GetRandomParallelepiped());
                        break;
                    default:
                        Console.WriteLine("Unknown chose of figure");
                        break;
                }
            }
            foreach (var figure in figureList)
            {
                Console.WriteLine(figure.Info);
                Console.WriteLine(figure.GetVolume());
            }
            Console.ReadKey();

        }
    }
}
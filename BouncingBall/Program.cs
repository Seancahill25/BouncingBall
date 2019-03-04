using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBall
{
    class BouncingBall
    {
        static void Main(string[] args)
        {
            Console.Write("Input Drop Height:");
            double h = float.Parse(Console.ReadLine());
            Console.Write("Input Bounce Rate:");
            double bounce = float.Parse(Console.ReadLine());
            Console.Write("Input Window Height:");
            double window = float.Parse(Console.ReadLine());

            Console.WriteLine("Result:" + BouncingBalls(h,bounce,window));
        }

        public static int BouncingBalls(double h, double bounce, double window)
        {
            var sightings = 1;
            if (bounce >= 1 || bounce <= 0 || h < window || h <= 0)
            {
                return -1;
            }
            else
            {
                while (h * bounce > window)
                {
                    h = h * bounce;
                    sightings += 2;
                }
            }
            return sightings;
        }
    }
}
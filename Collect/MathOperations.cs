using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect
{
    public class MathOperations
    {
        public static double[] FindRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[] { };
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                double sqrtDisc = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDisc) / (2 * a);
                double root2 = (-b - sqrtDisc) / (2 * a);
                return new double[] { root1, root2 };
            }
        }

        public static double CalculatePercentage(double number, double percent)
        {
            return (number * percent) / 100.0;
        }
    }

}

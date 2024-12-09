using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstbasics
{
    internal class CalculatorOfVolumes
    {
        static void Main(string[] args)
        {
            string shape = "Ellipse";
            double majorAxis = 11, minorAxis = 16;
            double topBase = 0, bottomBase = 0, height = 0;
            double base1 = 0, heightPara = 0;
            double areaResult;

            areaResult = shape switch
            {
                "Ellipse" => (3.14 * majorAxis * minorAxis),
               "Trapezoid" => (((topBase + bottomBase) / 2) * height),
               "Parallelogram" => (base1 * heightPara),
               _=> 0

            };
            Console.WriteLine(shape + " : " + areaResult);
              
        }
    }
}

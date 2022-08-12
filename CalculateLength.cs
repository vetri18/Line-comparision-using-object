using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CalculateLength
    {
        public void LengthOfLine(double x1, double y1, double x2, double y2)
        {
            double lengthOfLine;


            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a given Line is: " + lengthOfLine);
        }
    }
}
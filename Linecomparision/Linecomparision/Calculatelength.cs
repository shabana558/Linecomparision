using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision
{
    internal class Calculatelength
    {
                 //variable declaration
        public static int x1, x2, y1, y2, i;
        public static void calculatelength ()
        {
            Console.WriteLine("Enter value for coordinate \"x1\" ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"y1\" ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"x2\" ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"y2\" ");
            y2 = Convert.ToInt32(Console.ReadLine());
            //object for created for class FindingLength
            FindingLength obj = new FindingLength();
            obj.LineLength(x1, y1, x2, y2, i);
        }

    }
    
    public class Findinglength
    {
    
        public void linelength(int x1, int y1, int x2, int y2, int i)
        {
            //calculating formula for finding length
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Math.Round(sqrt, 2));
        }
    }

}
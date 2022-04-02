using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecommparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, p1, p2, q1, q2;
            x1 = 12d;x2 = 13d;y1 = 11d;y2 = 10d;
            p1 = 15;p2 = 18;q1 = 13;q2 = 15;
            var distance_l1= Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var distance_l2 = Math.Sqrt((Math.Pow(p1 - p2, 2) + Math.Pow(q1 - q2, 2)));
            if (distance_l1 == distance_l2)
                Console.WriteLine("Two lines are equal ");
            else
                Console.WriteLine("Not equal");
       
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Enter value of x1:");
            x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y1:");
            y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y2:");
            y2=Convert.ToInt32(Console.ReadLine());
            LineCompare obj = new LineCompare();
            obj.Line(x1, y1, x2, y2);
        }
    }
}
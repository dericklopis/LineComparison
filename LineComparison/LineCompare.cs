using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCompare
    {
        public void Line(int x1,int y1,int x2,int y2)
        {           
            int lengthofline1 = Math.Abs(x1-y1);
            int lengthofline2 = Math.Abs(x2-y2);
            if (lengthofline1==lengthofline2)
            {
                Console.WriteLine("Both line are equal in length");
            }
            else if (lengthofline1>lengthofline2)
            {
                Console.WriteLine("Length of the Line x1,y1 is greater than line x2,y2");
            }
            else
            {
                Console.WriteLine("Length of the Line x1,y1 is lesser than line x2,y2");
            }
            Console.ReadLine();
        }
    }
}


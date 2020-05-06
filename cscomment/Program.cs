using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            String x1, y1;

            Console.WriteLine("x : ");
            x1 = Console.ReadLine();
            x = Convert.ToInt32(x1);

            Console.WriteLine("y : ");
            y1 = Console.ReadLine();
            y = Convert.ToInt32(y1);


     

            if (x > 4)
            {
                if(y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

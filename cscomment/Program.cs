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
            /*주석?*/
            Console.Write("X 입력: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Y 입력: ");
            y = int.Parse(Console.ReadLine());

            if (x>4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x*y);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.WriteLine(Sum(12, 23));
            //Add(12,34)
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
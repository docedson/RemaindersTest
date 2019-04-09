using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemaindersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            Console.WriteLine(b * quotient + remainder);
        }
    }
}

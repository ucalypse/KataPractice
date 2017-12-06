using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Fizz
    {
        static void Main(string[] args)
        {
           // RunProgram();
        }
       
        public void RunProgram()
        {
            var i = 1;
            while (i <= 100)
            {
                if( i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    i++;
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

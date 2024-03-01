using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzz
    {
        public int maxNumber { get; set; }
        public FizzBuzz() 
        {
            Console.WriteLine("Podaj górny zakres liczb\n");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            display();
        }

        public void display() 
        {
            for (int i = 1; i <= maxNumber; i++) 
            {
                if ( i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

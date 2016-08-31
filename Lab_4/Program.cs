using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Console.WriteLine("Enter an integer that's greater than zero, but less than 10");
            string numberAnswer=Console.ReadLine();
            int numberAsAnint = int.Parse(numberAnswer);


            long Total = 1;
            //do factorial
            {
                if (numberAsAnint >= 0 || numberAsAnint < 10)
                   Total = FactorialCalc(numberAsAnint);
                        Console.ReadLine();
                        Console.WriteLine("The Factorial is " + Total);


                




                //int i;
                //int n;
                //for (i = 1,n = Convert.ToInt32(Console.ReadLine());n < 10; n--);
                //{
                //    i = Convert.ToInt32((i) * (n));
                //}
                // Console.WriteLine(i);
            }
        }
        static long FactorialCalc(int number)
        {
            long Total = 1;
            for (int Counter = number; Counter > 0; Counter--)
            {
                Console.WriteLine(Counter);
                Total = Total * Counter;

                Console.WriteLine(Total);
                            }
            return Total;
        }
    }
}

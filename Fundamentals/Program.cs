using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First ten positive numbers");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("First ten negative numbers");
            for(int i=0;i>-10; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            
            Console.WriteLine("First ten squared numbers");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i*i);
            }
            Console.WriteLine();

            Console.WriteLine("First ten even numbers");
            /*int found = 0;
            for(int i= 0; i < 50; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                    found++;
                    if (found >= 10)
                    {
                        break;
                    }
                        
                }
               
            }*/
            Console.WriteLine();
            for(int i= 0;i<10; i++)
            {
                Console.WriteLine(i*2);
            }
            Console.WriteLine();
            Console.WriteLine("First ten odd numbers");
            for(int i=0 ;i<10; i++)
            {
                Console.WriteLine(i*2+1);
            }
            Console.WriteLine();
            Console.WriteLine("Multiplication table of a number");

            int number = 7;
            for(int i=0; i < 12; i++)
            {
                Console.WriteLine($"{i}*{number}={i * number}");
            }
            Console.WriteLine();

            Console.WriteLine("An ascending geometry series");
            for(double v=1; v<100; v*=1.5)
                Console.WriteLine(v);
            Console.WriteLine();

            Console.WriteLine("Generating alphabet");

            string alphabet = "";

            for(int i=0;i<26; i++)
            {
                alphabet += (char) (65+i);
                //Console.WriteLine($"{i}:{alphabet}");

            }
            Console.WriteLine(alphabet);
            Console.WriteLine();

            Console.WriteLine("The addition of the first ten numbers");

            int addnum = 0;
            for(int i = 0;i<10; i++)
            {
                //addnum= addnum+i;
                addnum += i;
            }
            Console.WriteLine(addnum);
            Console.WriteLine();

            Console.WriteLine("Fibonnic sequence");
            int prev1 = 1;
            int prev2 = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);

            for(int i=0; i<10; i++)
            {
                int sum = prev1 + prev2;
                Console.WriteLine(sum);

                prev1 = prev2;
                prev2 = sum;
            }
            Console.WriteLine();

            Console.WriteLine("Prime Numbers");

            for(int i =2; i < 30; i++)
            {
                bool isPrime = true;
                for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

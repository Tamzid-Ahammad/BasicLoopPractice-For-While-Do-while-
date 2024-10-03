using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doing increment using for loop
            Console.WriteLine("Please give value under or equal to 100 for doing increment");
            for(int i = Convert.ToInt32(Console.ReadLine()); i<=100; i++)
            {
                Console.WriteLine(i);
            };
            //Doing decrement  using for loop
            Console.WriteLine("Please give value over 100 or under 200 for doing decrement");
            for (int i = Convert.ToInt32(Console.ReadLine()); i >= 100 && i <= 200; i--)
            {
                Console.WriteLine(i);
            };


            //NESTED LOOP
            //In C#, we can use for loop inside another for loop, it is known as nested for loop. The inner loop is executed fully when outer loop is executed one time. So if outer loop and inner loop are executed 3 times, inner loop will be executed 3 times for each outer loop i.e. total 9 times.
            /* output will be look like this
                1 1, 1 2 , 1 3
                2 1, 2 2 , 2 3
                3 1, 3 2 , 3 3
             
             */


            Console.WriteLine("It is represent a nested for loop");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }





            //While Loop practicing based on previous for loop
            Console.WriteLine("While Loop Practice Start from here");

            Console.WriteLine("Please give value under or equal to 100 for doing increment");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("Please give value over 100 or under 200 for doing decrement");

            int numForDecrement = Convert.ToInt32(Console.ReadLine());

            while (numForDecrement>= 100 && numForDecrement <= 200)
            {
                Console.WriteLine(numForDecrement);
                numForDecrement--;
            }

            Console.WriteLine("It is represent a nested while loop");
            int a = 1;
            while (a <= 3)
            {
                int b = 1;
                while (b <= 3)
                {
                    Console.WriteLine(a+" "+b);
                    b++;
                }
                a++;

            }




            //Do-While Loop practicing based on previous for loop

            Console.WriteLine("Do-While Loop Practice Start from here");
            Console.WriteLine("Please give value under or equal to 100 for doing increment");
            int numForDoWhile = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(numForDoWhile);
                numForDoWhile++;
            }
            while (numForDoWhile <= 100);

            Console.WriteLine("Please give value over 100 or under 200 for doing decrement");

            int numInDoWhileForDecrement = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(numInDoWhileForDecrement);
                numInDoWhileForDecrement--;
            }
            while(numInDoWhileForDecrement >= 100 && numInDoWhileForDecrement<= 200);


            Console.WriteLine("It is represent a nested do-while loop");
            
            int c = 1;
            do
            {
                int d = 1;
                do
                {
                    Console.WriteLine(c + " " + d);
                    d++;
                }
                while (d <= 3);
                c++;
            }
            while(c <= 3);





            Console.ReadLine();
        }
    }
}

using System;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
           double num1, num2, ans;
            Console.WriteLine("Basic Calculator: 1. ADD 2. Mul 3. Div 4. Sub");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                //Input numbers
                Console.WriteLine("1st Input: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2nd Input: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //Do operation
                ans = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {ans}"); 
            }
            else if (input == 2)
             {
                //Input numbers
                Console.WriteLine("1st Input: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2nd Input: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //DO operation
                ans = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {ans}");
             }
            else if (input == 3)
            {
                //Input numbers
                Console.WriteLine("1st Input: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2nd Input: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //Do operation
                ans = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {ans}");
            }
            else if (input == 4)
            {
                //Input numbers
                Console.WriteLine("1st Input: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2nd Input: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                //Do operation
                ans = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {ans}");
            }
            else
            {
                Console.WriteLine("Invalid Input!!");
            }
        }
    }
}

using System;

namespace DZ1
{
    class Program 
    {
        #region Пример № 1
        /*    static void Main(string[] args)
            {
                 Console.WriteLine( "Введите пожалуйста любое число");
                int number = int.Parse(Console.ReadLine());
                Test(number, out int result);
                if (result == 0)
                {
                    Console.WriteLine($"{result} Простое");
                }
                else 
                {
                    Console.WriteLine( $"{result} Не простое");
                }
            }
            public static int Test(int number, out int result)
            {
                int d = 0;
                int i = 2;
                while (i < number)
                {
                    if (number % i == 0) 
                    { 
                        d++; 
                    }
                    i++;
                }
                return result = d;
            }
        */

        #endregion

        #region Пример № 2
        /* public static int StrangeSum(int[] inputArray)
         {
             int sum = 0; // O(1)
             for (int i = 0; i < inputArray.Length; i++) // O(N)
             {
                 for (int j = 0; j < inputArray.Length; j++) // O(N)
                 {
                     for (int k = 0; k < inputArray.Length; k++) // O(N)
                     {
                         int y = 0; // O(1) 
                         if (j != 0) //O(2) - 2 шага если условие выполняется.
                         {
                             y = k / j; 
                         }
                         sum += inputArray[i] + i + k + j + y; // O(1)
                     }
                 }
             }
             return sum; // O(1)
         }
        */


        // Подсчет ассимптотической сложности
        // O(1) + O(N) * ( O(N) * ( O(N) * ( O(1) + O(2) + O(1) ) ) ) + O(1) = 
        // = O(2) + O(N) * O(N) * O(3N) =
        // = O(2) + O(3N^3) =
        // = O(2+3N^3) =
        // = O(N^3)	 
        #endregion


        #region Пример № 3

        /* static void Main(string[] args) 
         {
             Console.WriteLine("Введите число ");
             int number = int.Parse(Console.ReadLine());
             Console.WriteLine(Fibonacci(number));
         }
         static int Fibonacci(int n)
         {
             int a = 0;
             int b = 1;
             int tmp;
             for (int i = 0; i < n; i++)
             {
                 tmp = a;
                 a = b;
                 b += tmp;
             }
             return a;
         }
        */

        #endregion


    }
}
    


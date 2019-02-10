using System;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел должно быть в массиве?");
            Console.Write("Чисел в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            int i1 = 1, i2 = 1;
            int[] ch = new int[n];
            int[] nc = new int[n];

            for (int i=0; i<=n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.Read());

                if (numbers[i]%2 == 0)
                {
                    //ch[i1] = numbers[i];
                    i1++;
                    Console.WriteLine("- Четное число");
                } else
                {
                    //nc[i2] = numbers[i];
                    i2++;
                    Console.WriteLine("- Нечетное число");
                }

            }



            Console.ReadKey();
        }
    }
}

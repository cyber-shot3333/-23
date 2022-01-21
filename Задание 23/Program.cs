using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static int n;

        static void Main(string[] args)
        {           
            try
            {
                Console.Write("Введите целое число, факториал которого хотите получить: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    FactorialAsync();
                }
                else
                {
                    Console.WriteLine("Число не должно быть отрицательным");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
            Console.ReadKey();
        }
        static void Factorial()
        {
            ulong result = 1;
            if (n >= 2)
            {
                for (int i = 1; i <= (n - 1); i++)
                {
                    result *= (ulong)(i + 1);
                }
            }
            Console.WriteLine($"{n}! = {result}");
        }
        static async void FactorialAsync()
        {           
            await Task.Run(() => Factorial());
        }
    }
}
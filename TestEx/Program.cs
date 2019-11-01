using System;

/*3.	Гонщик Никодим никак не может выбрать номер для участия в гонке. 
 Он хочет, чтобы циклическая сумма цифр его номера была равна N (0 <= N <= 9). 
 Помогите Никодиму, выведите все подходящие номера от 0 до M.
 Пример подсчета циклической суммы: 774 -> 7 + 7 + 4 = 18 -> 1 + 8 = 9)
*/

namespace TestEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number");
            string input = Console.ReadLine();
            int M = 0;
            try
            {
                M = checked(Int32.Parse(input));
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException");
                return;
            }

            for (int i = 0; i <= M; i++)
            {
                int result = i;
                for (int j = 0; j < (M.ToString().Length - 1); j++) 
                {
                    result=cycle(result);
                }

                if (result < 10)
                {
                    Console.WriteLine($"number {i} = {result}");
                }
            }
        }

        static int cycle(int n)
        {
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада ");
            var depositeAmount = Console.ReadLine();
            if (double.TryParse(depositeAmount, out var amount))
            {
            var profitNineMounths = amount * 0.08 * (9.0/ 12.0);
            var profitTwelveMounths = amount* 0.095 * (12.0 / 12.0);
            var profitEighteenMounths = amount * 0.1 *(18.0 / 12.0);

            Console.WriteLine($"Прибыль за 9 месяцев под 8% годовых: {profitNineMounths} рублей.");
            Console.WriteLine($"Прибыль за 12 месяцев под 9.5% годовых: {profitTwelveMounths} рублей.");
            Console.WriteLine($"Прибыль за 18 месяцев под 10% годовых: {profitEighteenMounths} рублей.");
            }
            else
            {
                Console.WriteLine("Ввод не верен");
            }
        }
    }
}

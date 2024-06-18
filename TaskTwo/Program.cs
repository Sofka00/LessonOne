using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму продаж: ");
             double salesAmount =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите план продаж: ");
            double salesPlan = Convert.ToDouble(Console.ReadLine());

            double bonus;
            if (salesAmount <= salesPlan)
            {
                bonus = salesAmount * 0.05;
            }
            else
            {
                bonus = (salesAmount * 0.05) + ((salesAmount - salesPlan) * 0.10);
                
            }
            Console.WriteLine($"Бонус сотрудника равен {bonus} рублей. ");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину пути в километрах: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fixedPrice = 150d;
            double perKmPrice = 70d;
            double deliveryCost = fixedPrice + (perKmPrice * distance);
            Console.WriteLine($"Стоимость доставки: {deliveryCost}");
        }
    }
}

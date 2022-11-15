using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Разработать структуру для решения линейного уравнения 0=kx+b. \n" +
                "Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.\n" +
                "Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.\n" +
                "Осуществить использование экземпляра в программе.");

            Console.Write("k=");
            double k = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            Lin lin =new Lin(k, b);
            Console.WriteLine("x={0}",lin.Root());
            Console.ReadKey();
        }
    }
}

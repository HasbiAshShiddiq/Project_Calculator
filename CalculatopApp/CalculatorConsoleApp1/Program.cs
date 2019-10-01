using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorClassLibrary1;

namespace CalculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan A : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("INputkan B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            Console.WriteLine("Hasil Penjumlahan : {0} + {1} = {2}", a, b, cal.penambahan(a, b));
            Console.WriteLine("Hasil Penngurangan : {0} - {1} = {2}", a, b, cal.pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, b, cal.perkalian(a, b));
            Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", a, b, Calculator.pembagian(a, b));
            Console.WriteLine("Hasil Pangkat : {0} ^ {1} = {2}", a, b, cal.pangkat(a, b));
            Console.WriteLine("Hasil Modulo : {0} % {1} = {2}", a, b, cal.Modulo(a, b));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary1
{
    public class Calculator
    {
        public int penambahan(int a, int b)
        {
            return a + b;
        }
        public int pengurangan(int a, int b)
        {
            return a - b;
        }
        public int perkalian(int a, int b)
        {
            return a * b;
        }
        public static int pembagian(int a, int b)
        {
            return a / b;
        }
        public int pangkat(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}

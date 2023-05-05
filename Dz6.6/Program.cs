using System;

namespace Dz6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2; if (a > 10 & ++b < 3) { a++; }
            Console.Write("a={0} ", a); Console.Write("b={0}", b);
            Calculator.Number = 0;
            Calculator.Add(1, 23, 4.5, 44);
            Calculator.Divide(1, 33, 2);
            Calculator.Subtract(21, 3);
            Calculator.Multiply(21, 3);
            Console.WriteLine(Calculator.Number);
            Console.ReadKey();
            
        }
    }
    static class Calculator
    {
        public static double Number { get; set; }
        
        static public void Add(params double[] Numb)
        {
            for(int i = 0;i<Numb.Length;i++)
            {
                Number += Numb[i];
            }
        }
        static public void Subtract(params double[] Numb)
        {
            for (int i = 0; i < Numb.Length; i++)
            {
                Number -= Numb[i];
            }
        }
        static public void Multiply(params double[] Numb)
        {
            for (int i = 0; i < Numb.Length; i++)
            {
                Number *= Numb[i];
            }
        }
        static public void Divide(params double[] Numb)
        {
            for (int i = 0; i < Numb.Length; i++)
            {
                Number /= Numb[i];
            }
        }
    }
}

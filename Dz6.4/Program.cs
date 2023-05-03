using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting(1, 2, 3, 4, 5, 6) ;
            sorting.Sort();
            sorting.Add(10);
            sorting.Add(20);
            sorting.Sort();
            Console.ReadLine();
        }
    }
    class Sorting
    {
        private int[] ints = new int[0];
        public Sorting(params int[] yes) {
            ints = yes;  
        }
        public void Sort()
        {
            Array.Sort(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
        public void Add(int value)
        {
            int[] newInts = new int[ints.Length + 1];
            Array.Copy(ints, newInts, ints.Length);
            newInts[ints.Length] = value;
            ints = newInts;
        }
    }
}

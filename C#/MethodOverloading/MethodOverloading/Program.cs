using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    class Program
    {
        private int x;
        private int y;
        public int sum(int x, int y)
        {
            Console.Write("Sum of int:");
            return x + y;
        }
        public double sum(double x, double y)
        {
            Console.Write("Sum of double:");
            return x + y;
        }
        public int sum(params int[] numList)
        {
            int s = 0;
            foreach (int n in numList)
            {
                s += n;
            }
            Console.Write("Sum of params:");
            return s;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.sum(4, 5));
            Console.WriteLine(p1.sum(12.3, 4.3));
            Console.WriteLine(p1.sum(1, 2, 3, 5, 6, 8));
            Console.ReadLine();
        }
    }
}

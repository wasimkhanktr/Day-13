using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maximum maximum = new Maximum();
            int max = maximum.FindMax(2, 1, 3);
            Console.WriteLine(max);
        }
    }
}
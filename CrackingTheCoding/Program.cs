using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraysAndStrings = new ArraysAndStrings();

            Console.WriteLine($"IsUnique: {arraysAndStrings.IsUnique("tes")}");

            Console.WriteLine($"IsPermutation: {arraysAndStrings.IsPermutation("test", "esTt")}");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCoding
{
    class ArraysAndStrings
    {
        // 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures
        public bool IsUnique(string str)
        {
            var asciiArr = new bool[128];

            foreach(char c in str)
            {
                if (asciiArr[c]) return false;

                asciiArr[c] = true;
            }

            return true;
        }

        // 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
        public bool IsPermutation(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            // if lengths are different they can't be permutations of each other
            if (str1.Length != str2.Length) return false;

            int asciiSumStr1 = 0;
            int asciiSumStr2 = 0;
            for (var i = 0; i < str1.Length; i++)
            {
                asciiSumStr1 += str1[i];
                asciiSumStr2 += str2[i];
            }

            Console.WriteLine($"ASCII sum of Str1: {asciiSumStr1}, Str2: {asciiSumStr2}");

            // if their ascii code sums match they are permutations of each other
            return asciiSumStr1 == asciiSumStr2;
        }
    }
}

using System;

namespace Algorhitms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.w3resource.com/csharp-exercises/basic-algo/index.php

            Console.WriteLine("result (3): " + sumConditional(1, 2));
            Console.WriteLine("result (5): " + sumConditional(3, 2));
            Console.WriteLine("result (12): " + sumConditional(2, 2));


            Console.WriteLine("result (true): " + boolConditional(30, 0));
            Console.WriteLine("result (true): " + boolConditional(25, 5));
            Console.WriteLine("result (true): " + boolConditional(20, 30));
            Console.WriteLine("result (false): " + boolConditional(20, 25));

            Console.WriteLine("result (true): " + boolConditionalRange(103));
            Console.WriteLine("result (true): " + boolConditionalRange(90)); // true
            Console.WriteLine("result (false): " + boolConditionalRange(89));

            Console.WriteLine("result (if else): " + stringConditionalAdd("if else"));
            Console.WriteLine("result (if else): " + stringConditionalAdd("else"));

            Console.WriteLine("result (Pthon): " + stringRemoveAtIndex("Python", 1));
            Console.WriteLine("result (ython): " + stringRemoveAtIndex("Python", 0));
            Console.WriteLine("result (Pythn): " + stringRemoveAtIndex("Python", 4));

            Console.WriteLine("result (dbca): " + switchFirstLastCharacter("abcd"));
            Console.WriteLine("result (a): " + switchFirstLastCharacter("a"));
            Console.WriteLine("result (yx): " + switchFirstLastCharacter("xy"));

            Console.WriteLine("result (dRedd): " + addLastCharacter("Red"));

            Console.WriteLine("result (true): " + checkMultiple(3));
            Console.WriteLine("result (true): " + checkMultiple(14));
            Console.WriteLine("result (true): " + checkMultiple(12));
            Console.WriteLine("result (false): " + checkMultiple(37));

            Console.WriteLine("result (95): " + checkNearest(78, 95));
            Console.WriteLine("result (0): " + checkNearest(95, 95));
            Console.WriteLine("result (99): " + checkNearest(99, 70));
            Console.WriteLine("result (101): " + checkNearest(95, 101));

        }

        private static int sumConditional(int a, int b)
        {
            // Write a C# Sharp program to compute the sum of the two given integer values.
            // If the two values are the same, then return triple their sum.
            return a == b ? (a + b) * 3 : a + b;
        }


        private static bool boolConditional(int a, int b)
        {
            //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
            return a == 30 || b == 30 || (a + b == 30);
        }

        private static bool boolConditionalRange(int a)
        {
            //Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
            return a >= 90 && a <= 110 || a >= 190 && a <= 210;
        }

        private static string stringConditionalAdd(string s) 
        {
            //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
            //If the string already begins with 'if', return the string unchanged.
            return s.StartsWith("if") ? s : s = "if else";
        }

        private static string stringRemoveAtIndex(string s, int a)  
        {
            //Write a C# Sharp program to remove the character in a given position of a given string.
            //The given position will be in the range 0.. string length -1 inclusive.
            return s.Remove(a, 1);
        }

        private static string switchFirstLastCharacter(string s) 
        {
            //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
            return s.Length > 2 ? s.Substring(s.Length-1) + s.Substring(1, s.Length-2) + s.Substring(0, 1) : s;
        }

        private static string addLastCharacter(string s) 
        {
            //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
            return s.Substring(s.Length - 1) + s + s.Substring(s.Length - 1);
        }

        private static bool checkMultiple(int a) 
        {
            //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
            //return a % 3 == 0 ? true : a % 7 == 0 ? true : false;
            return a % 3 == 0 || a % 7 == 0;

        }

        public static int checkNearest(int a, int b) 
        {
            //Write a C# Sharp program to check which number nearest to the value 100 among two given integers.
            //Return 0 if the two numbers are equal.
            return a == b ? 0 : Math.Abs(100 - a) < Math.Abs(100 - b) ? a : b;
        }



    }
}
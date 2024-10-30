﻿using System;

namespace Average_of_three
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
        }
        
        public static int MiddleOf(int a, int b, int c)
        {
            if (a >= b && a <= c ||a>=c && a<=b )
                return a;
            else if (b >=a && b <= c || b <= a && b >= c)
                return b;
            else
                return c;
            
        }
    }
}
﻿using System;

namespace Convert_string_to_number
{
    class Program
    {
        public static void Main()
        {
            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);
        }
    }
}
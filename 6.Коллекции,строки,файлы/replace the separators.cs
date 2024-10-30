﻿using System;

namespace splitAndJoin
{
    class Program
    {
        static string citiesPopulation()
        {
            string[] data =
            {
                " Страна Население Дата % ",
                " Китай: 1405023000; 24.08.2020; 17.99% ",
                " Индия: 1375100000 24.08.2020 17.6% ",
                " США: 329957441; 15.07.2020; 4.24% ",
                " Индонезия 266911900; 01.07.2019 3.42% ",
                " Пакистан - 218647040 24.08.2020; 2.8% ",
                " Бразилия 211950300; 24.08.2020; 2.71% ",
                " Нигерия 208426036; 24.08.2020; 2.67% ",
                " Бангладеш 171147762 24.08.2020; 2.19% ",
                " Россия: 146748590; 01.01.2020 1.88% ",
                " Мексика - 127792286, 01.07.2020, 1.64% ",
                " Япония 125950000; 01.03.2020, 1.61% ",
                " Эфиопия 112079000, 01.07.2019 1.43% ",
                " Филиппины 108968790, 24.08.2020; 1.39% ",
                " Египет 100812120, 24.08.2020 1.29% ",
                " Вьетнам 96208984; 01.04.2019; 1.23% ",
                " ДРК 86791000, 01.07.2019, 1.11% ",
                " Иран 84393386 24.08.2020 1.08% ",
                " Турция - 83154997 1.01.2020 1.06% ",
                " Германия - 83149300 1.10.2019 1.06% "
            };
            return string.Join("", data);
        }

        public static void Main(string[] args)
            {
                Console.WriteLine(ReplaceIncorrectSeparators(citiesPopulation()));
            }
            
        public static string ReplaceIncorrectSeparators(string text)
            {
                var divide = new char[]{' ', '-', ':', ';', ','};
                return string.Join("\t", text.Split(divide, StringSplitOptions.RemoveEmptyEntries));
            }
        
    }
}

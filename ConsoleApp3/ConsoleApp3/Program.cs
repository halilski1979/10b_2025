﻿namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Прочитаме едно цело десетично число
            int dec = int.Parse(Console.ReadLine());

            // Конвериране към шестнадесетично и двоично
            var hex = Convert.ToString(dec, 16).ToUpper();
            var bin = Convert.ToString(dec, 2);

            // Отпечатване на получените стойности
            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}

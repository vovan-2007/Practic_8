﻿namespace lab8t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

namespace lab8t17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите математическое выражение: ");
            string express = Console.ReadLine();
            var result = new System.Data.DataTable().Compute(express, null);
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

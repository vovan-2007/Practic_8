namespace lab8t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"Результат: {new string(chars)}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

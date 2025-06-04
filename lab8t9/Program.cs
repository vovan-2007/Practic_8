namespace lab8t9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.Write("Что заменить: ");
            string oldelements = Console.ReadLine();
            Console.Write("На что заменить: ");
            string newelements = Console.ReadLine();
            string result = input.Replace(oldelements, newelements);
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

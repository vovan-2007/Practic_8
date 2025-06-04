namespace lab8t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char lower = char.ToLower(c);
            bool isVowel = "aeiouy".Contains(lower);
            Console.WriteLine(isVowel ? "Это гласная" : "Это не гласная");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

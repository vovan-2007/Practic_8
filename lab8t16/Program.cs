namespace lab8t16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            string[] filtered = lines.Where(line => line.Length >= 5).ToArray();
            File.WriteAllLines("filtered.txt", filtered);
            Console.WriteLine($"Удалено {lines.Length - filtered.Length} строк");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

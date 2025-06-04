namespace lab8t12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("secret.txt");
            string encrypted = new string(content.Select(c => char.IsLetter(c) ? '*' : c).ToArray());
            File.WriteAllText("encrypted.txt", encrypted);
            Console.WriteLine("Файл зашифрован");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

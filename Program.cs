using MyClassLibrary;
internal class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 15;
        int c = 20;
        double res = MyClassLibrary.Task1_3.PerSquare(a);
        double res1 = MyClassLibrary.Task1_3.PerRectangle(a, b);
        double res2 = MyClassLibrary.Task1_3.PerTriangle(a, b, c);
        Console.WriteLine($"Периметр квадрату = {res}");
        Console.WriteLine($"Периметр прямокутрика = {res1}");
        Console.WriteLine($"Периметр трикутника = {res2}");
        string palindromeText = "шалаш";
        bool isPalindrome = MyClassLibrary.Task1_3.IsPalindrome(palindromeText);
        string sentenceText = "Перше речення. Друге речення.";
        int sentenceCount = MyClassLibrary.Task1_3.CountSentences(sentenceText);
        string originalText = "Hello, World!";
        string reversedText = MyClassLibrary.Task1_3.ReverseString(originalText);
        Console.WriteLine($"Слово '{palindromeText}' палiндром? {isPalindrome}");
        Console.WriteLine($"Кiлькiсть речень: {sentenceCount}");
        Console.WriteLine($"Оригiнальний текс: {originalText}");
        Console.WriteLine($"Обернений текст: {reversedText}");
    }
}

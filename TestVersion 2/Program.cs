using TestVersion_2;

class Program
{
    static void Main(string[] args)
    {
        string testData = "1 2 3 4 5 6 7";
        NumberArray arr = new NumberArray(testData);

        arr.PrintArray();
        Console.WriteLine($"Количество нечетных: {arr.OddCount}");
        Console.WriteLine($"Произведение до последнего кратного 3: {arr.GetProductBeforeLastMultipleOfThree()}");

        Console.ReadKey();
    }
}

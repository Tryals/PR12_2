class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст");
        string line = Console.ReadLine();
        HashSet<char> setLine = TranslateLineToSet(line);
        PrintSet(setLine);
        HashSet<char> setDigit = new HashSet<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        PrintSet(setDigit);
        HashSet<char> newSet = setLine;
        newSet.IntersectWith(setDigit);
        PrintSet(newSet);
        Console.ReadKey();
    }
    private static HashSet<char> TranslateLineToSet(string word)
    {
        HashSet<char> setWord = new HashSet<char>();
        foreach (char c in word)
        {
            setWord.Add(c);
        }
        return setWord;
    }
    private static void PrintSet(HashSet<char> set)
    {
        foreach (char c in set)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
    }
}

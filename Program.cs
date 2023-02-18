// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Task 4

string inputText = Console.ReadLine();
char delimiterrr = char.Parse(Console.ReadLine());

Console.WriteLine(inputText.CountParts(delimiterrr));


public static class ExstensionMethod
{
    public static int CountParts(this string source, char delimiter)
    {
        int partCount = 1;
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] == delimiter)
            {
                partCount++;
            }
        }

        return partCount;
    }
}

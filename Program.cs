// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Task 7

char char1 = char.Parse(Console.ReadLine());
char char2 = char.Parse(Console.ReadLine());

int count = Math.Abs(char1 - char2);
Console.WriteLine(count);

for (int i = char1; i < char2; i++)
{
    Console.WriteLine((char)i);
}






// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int inputSize = int.Parse(Console.ReadLine());
double[,] matrix = new double[inputSize, inputSize];
//int flag = 0;

for (int row = 0; row < inputSize; row++)
{
    for (int col = 0; col < inputSize; col++)
    {
        matrix[row, col] = Math.Pow(2, (col + row));
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}

double sum = 0;
for (int r = 0; r < inputSize; r++)
{
    for (int c = 0; c < inputSize; c++)
    {
        if (c > r)
        {
            sum += matrix[r, c];
        }

    }
}
Console.WriteLine(sum);


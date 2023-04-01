// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Enter the size of array: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

double[,] matrix = new double[size[0], size[1]];

void InputMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
InputMatrix(matrix);

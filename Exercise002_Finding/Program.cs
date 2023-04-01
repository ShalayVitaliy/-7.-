// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
Console.Write("Enter the size of your matrix: ");
int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[Size[0], Size[1]];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 16);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
InputMatrix(Matrix);

Console.Write("What element do you want: ");
int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

void FindElement(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == Position[1] && j == Position[0])
            {
                Console.WriteLine($"{matrix[i,j]}");
                break;
            }
        }
        
    }
    
}

FindElement(Matrix);
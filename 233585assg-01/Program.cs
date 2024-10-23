using System;
class Program
{
    static void Main()
    {
        int[,,] matrix = new int[3, 3, 3];
        Console.WriteLine("Enter Elements of matrix 3 3 3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"Element is [{i},{j},{k}]: ");
                    matrix[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }
        int Sum_of_diagnol = 0;
        for (int i = 0; i < 3; i++)
        {
            Sum_of_diagnol += matrix[i, i, i];
        }
        Console.WriteLine("Result(Sum of diagnols): " + Sum_of_diagnol);
    }
}

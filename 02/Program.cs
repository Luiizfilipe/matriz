using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j)
                {
                    matriz[i, j] = 1;
                }
                else
                {
                    matriz[i, j] = 0;
                }
            }
        }

        Console.WriteLine("Matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

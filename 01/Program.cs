using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        int maiorValor = int.MinValue;
        int linhaMaior = 0, colunaMaior = 0;

        Console.WriteLine("Digite os valores da matriz 4x4: ");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
                if (matriz[i, j] > maiorValor)
                {
                    maiorValor = matriz[i, j];
                    linhaMaior = i;
                    colunaMaior = j;
                }
            }
        }

        Console.WriteLine($"Maior valor: {maiorValor} na posição ({linhaMaior}, {colunaMaior}) ");
    }
}

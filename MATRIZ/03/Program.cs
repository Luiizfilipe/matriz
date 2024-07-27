using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        int contador = 0;

        Console.WriteLine("Digite os valores da matriz 4x4: ");
        
        for (int i = 0; i < 4; i++ )    
            
            
            {
            for (int j = 0; j < 4; j++ )
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
                if (matriz[i, j] > 10 )
                {
                    contador++;
                }
            }
        }

        Console.WriteLine($" Número de valores maiores que 10: {contador} ");
    }
}

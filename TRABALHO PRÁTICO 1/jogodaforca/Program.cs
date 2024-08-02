// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] palavras = { "cachorro", "gato", "elefante", "girafa", "leao" };
            Random random = new Random();
                string palavraSecreta = palavras[random.Next(palavras.Length)];

            char[] palavraAdivinhada = new string('_', palavraSecreta.Length).ToCharArray();
                List<char> letrasUsadas = new List<char>();

            int tentativas = palavraSecreta.Length + 5; // Número de tentativas

        while (tentativas > 0)
        {
            Console.Clear();
            Console.WriteLine($"Palavra: {new string(palavraAdivinhada)}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", letrasUsadas)}");
            Console.WriteLine($"Tentativas restantes: {tentativas}");
            Console.Write("Digite uma letra: ");
            char letra;

            try
            {
                letra = Convert.ToChar(Console.ReadLine().ToLower());
            }
            catch
            {
                Console.WriteLine("Por favor, insira uma única letra. ");
                continue;
            }

            if (letrasUsadas.Contains(letra))
            {
                Console.WriteLine("Você já usou essa letra. Tente outra. ");
                continue;
            }

            letrasUsadas.Add(letra);

            if (palavraSecreta.Contains(letra))
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == letra)
                    {
                        palavraAdivinhada[i] = letra;
                    }
                }
            }
            else
            {
                tentativas--;
            }

            if (new string(palavraAdivinhada) == palavraSecreta)
            {
                    Console.WriteLine($"Parabéns! Você adivinhou a palavra: {palavraSecreta}");
                    return;
                }
        }

            Console.WriteLine($"Você perdeu!!! A palavra era.: {palavraSecreta}");
    }
}


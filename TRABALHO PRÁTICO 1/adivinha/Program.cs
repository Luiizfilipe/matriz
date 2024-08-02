using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Dificuldade do jogo!: Fácil (F), Médio (M), Difícil (D)" );
            string dificuldade = Console.ReadLine().ToUpper();

            int numeroMinimo, numeroMaximo, vidas;

        switch (dificuldade)
        {
            case "F":
                numeroMinimo = 1;
                numeroMaximo = 10;
                vidas = 3;
                break;
                    case "M":
                    numeroMinimo = 1;
                    numeroMaximo = 50;
                    vidas = 4;
                    break;
                         case "D":
                            numeroMinimo = 1;
                            numeroMaximo = 100;
                            vidas = 5;
                            break;
            default:
                Console.WriteLine("Dificuldade inválida.");
                return;
        }


        Random random = new Random();
                    int numeroSecreto = random.Next(numeroMinimo, numeroMaximo + 1);

        while (vidas > 0)   
            
            {
            Console.WriteLine($"Você tem {vidas} vidas. Tente adivinhar o número entre {numeroMinimo} e {numeroMaximo}:");
            if (int.TryParse(Console.ReadLine(), out int palpite))
            {
                if (palpite < numeroMinimo || palpite > numeroMaximo)
                {
                    Console.WriteLine($"Por favor, insira um número entre {numeroMinimo} e {numeroMaximo}.");
                    continue;
                }

                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você adivinhou o número. ");
                        return;
                }
                else
                {
                            vidas--;
                            if (vidas > 0)
                            {
                                Console.WriteLine("Errado! Tente novamente. ");
                            }
                            else
                            {
                                Console.WriteLine($"Você perdeu. O número era {numeroSecreto}. ");
                            }
                }
            }
            else
            {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número. ");
            }
        }
    }
}

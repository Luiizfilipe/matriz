// See https://aka.ms/new-console-template for more information
double lado1, lado2, valor, dobro;

Console.Write ("Informe o lado1: ");
    lado1 = double.Parse (Console.ReadLine());

Console.Write ("Informe o lado2: ");
    lado2 = double.Parse (Console.ReadLine());

valor = lado1 + lado2; 

    Console.WriteLine ($"O valor dos lados do quadrado e: {valor}");

dobro = valor * 2;

    Console.WriteLine ($"O dobro do quadrado e: {dobro} ");



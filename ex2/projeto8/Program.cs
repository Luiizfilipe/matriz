// See https://aka.ms/new-console-template for more information

double km, velocidade;

Console.WriteLine("Infomer a distancia: ");
    km = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a velociadade: ");
    velocidade = double.Parse(Console.ReadLine());

Console.WriteLine ($"O tempo da viagem e igual a: {km/velocidade} hrs!");
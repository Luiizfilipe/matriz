// See https://aka.ms/new-console-template for more information
int seg, min, horas, dia;

Console.Write("Quantidades de dias? ");
    dia = int.Parse (Console.ReadLine());

Console.Write("Quantidades de horas? ");
    horas = int.Parse (Console.ReadLine());

Console.Write("Quantidades de minutos? ");
    min = int.Parse (Console.ReadLine());

Console.Write("Quantidades de segundos? ");
    seg = int.Parse (Console.ReadLine());

horas =  horas + (dia * 24);
min = min + (horas * 60);
seg = seg + (min* 60);

    Console.WriteLine ($"Um minuto tem {seg}");

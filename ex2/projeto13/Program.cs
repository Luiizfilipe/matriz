// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Globalization;

double bruto, horas, liquido, ir, inss, sindicato;
int hrt;

Console.WriteLine("Informe valor de horas trabalhada:");
    horas = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o tempo de horas trabalhada:");
    hrt = int.Parse(Console.ReadLine());
bruto = horas * hrt;
Console.WriteLine($"SALARIO BRUTO : : {bruto}");
Console.WriteLine($"IR(11%) : {ir = bruto* 11 /100}");
Console.WriteLine($"INSS(8%) : {inss= bruto * 8 / 100}");
Console.WriteLine($"SINDICATO (5%) : {sindicato= bruto *5 / 100}");
bruto =bruto -ir - inss - sindicato;
Console.WriteLine($"SALARIO LIQUIDO : {bruto}");






// See https://aka.ms/new-console-template for more information
Double altura, peso, imc;

Console.WriteLine("Informe sua altura: ");
    altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe sua peso: ");
    peso = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);
 
 Console.WriteLine($"O seu peso ideal e : {imc}");



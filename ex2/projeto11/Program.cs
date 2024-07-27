// See https://aka.ms/new-console-template for more information
int num1, num2;
double num3;

Console.WriteLine("Inforome o  numero: ");
    num1 = int.Parse (Console.ReadLine());

Console.WriteLine("Inforome o numero: ");
    num2 = int.Parse (Console.ReadLine());

Console.WriteLine("Inforome o numero: ");
    num3 = double.Parse (Console.ReadLine()); 

Console.WriteLine($"A; {(num1 *2) *(num2 /2)}");
Console.WriteLine($"B; {(num1 * 3) + num3}");
Console.WriteLine($"C; {Math.Pow(num3, 3)}");






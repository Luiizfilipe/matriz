// See https://aka.ms/new-console-template for more information
byte anos, meses, dias;
Console.WriteLine ("quantos anos: ");
    anos = byte.Parse(Console.ReadLine());
Console.WriteLine ("quantos meses: ");
    meses = byte.Parse(Console.ReadLine());
Console.WriteLine ("quantos dias: ");
   dias = byte.Parse(Console.ReadLine());

int total;

total = anos * 365;
total = total + meses * 30;
total = total + dias;

Console.WriteLine($"valot total em dias: {total}");



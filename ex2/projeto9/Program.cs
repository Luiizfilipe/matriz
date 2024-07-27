// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

int anos, dia, perdido;


Console.WriteLine("QUantos dias voce fuma? ");
    dia = int.Parse(Console.ReadLine());

Console.WriteLine("QUantos anos voce fuma? ");
    anos = int.Parse(Console.ReadLine());


perdido = dia * 10 * 365 *anos /(60*24);


    Console.WriteLine ($"A quantidade de dias perdidos e : {perdido}!");



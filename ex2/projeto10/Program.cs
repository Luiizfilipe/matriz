// See https://aka.ms/new-console-template for more information

int hora, mes, salario;

Console.WriteLine ("Quantos voce ganha por hora? ");
    hora = int.Parse (Console.ReadLine());

Console.WriteLine ("Quantas horas voce trabalha por mes ? ");
    mes = int.Parse (Console.ReadLine());

salario = hora * mes;

Console.WriteLine ($"O seeu salario por mes e aquivalente a:{salario}$");






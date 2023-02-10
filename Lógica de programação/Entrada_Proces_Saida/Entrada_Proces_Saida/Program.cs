﻿using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int A, B, soma;

        Console.WriteLine("Infome o primeiro valor: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo valor: ");
        B = int.Parse(Console.ReadLine());
        soma = A + B;

        Console.WriteLine("SOMA = " + soma);

        int a, b, c, d, diferenca;

        Console.WriteLine("Informe o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de B: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de C: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de D: ");
        d = int.Parse(Console.ReadLine());

        diferenca = (a * b) - (c * d);

        Console.WriteLine("Diferença = " + diferenca);

        int num, horasTrab;
        double salario, salarioTotal;

        Console.WriteLine("Digite seu número: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite as horas trabalhadas: ");
        horasTrab= int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salário por hora: ");
        //InvariantCulture nesse caso como o pc está em port ele converte para "." e não ","
        salario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salarioTotal = horasTrab * salario;

        Console.WriteLine("Number = " + num);
        Console.WriteLine("Salario = U$" + salarioTotal.ToString("f2"));
    }
}
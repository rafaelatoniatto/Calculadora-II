using System;
using System.Collections.Generic;

using System.Text;

//Programa de uma calculadora simples
class Calculadora
{
    static void Main(string[] args)
    {
        double num1, num2;


        Console.WriteLine("CALCULADORA SIMPLES \r\n");
        Console.WriteLine("Digite o primeiro número:");
        num1 = double.Parse(Console.ReadLine());


        Console.WriteLine("Digite o segundo número:");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\r\nO resultado da sua soma é {0}", num1 + num2);
        Console.WriteLine("O resultado da sua substração é {0}", num1 - num2);
        Console.WriteLine("O resultado da sua multiplicação é {0}", num1 * num2);
        Console.WriteLine("O resultado da sua divisão é {0}", num1 / num2);

        Console.ReadLine();
        Console.ReadKey();

    }
}

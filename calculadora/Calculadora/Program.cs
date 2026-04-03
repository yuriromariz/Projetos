using Calculadora.models;
using System;
public class Program
{
    public static void Main()
    {
        int x = 0;
        int y = 0;
        string operacao = "";
        CalculadoraBasica calc = new();
        while (operacao != "sair")
        {
            Console.WriteLine(@"Digite o tipo de operação que deseja fazer.
+ = soma.
- = subtração.
* = multiplicação.
/ = dividisão.
** = potencia.
Sair = Encerra o Programa. ");

            operacao = Console.ReadLine()!.ToLower();
            if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/"
             && operacao != "sair" && operacao != "**")
            {
                Console.WriteLine("Operação Inválida");
            }
            else if (operacao == "sair")
                break;
            else
            {

                Console.WriteLine("Digite o 1 numero a ser calculado: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 2 numero a ser calculado: ");
                y = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case "+":
                        calc.Somar(x, y);
                        break;
                    case "-":
                        calc.Subtrair(x, y);
                        break;
                    case "*":
                        calc.Multiplicar(x, y);
                        break;
                    case "/":
                        calc.Dividir(x, y);
                        break;
                    case "**":
                        calc.Potencializar(x, y);
                        break;
                }

            }
        }
        Console.WriteLine("Encerrando Programa. ");
    }
}

using System;
using calculadora.Entities;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            while (!calc.Encerrada)
            {
                try
                {
                    Console.WriteLine("Calculadora");
                    Console.WriteLine("Digite uma operação sendo\n\r + Somar \n\r - Subtrair \n\r * Multiplicar \n\r / Dividir \n\r ou S para sair");
                    string operação = Console.ReadLine().ToUpper();
                    calc.validacoes(operação);
                    Console.Write("Digite o primeiro valor: ");
                    double valor1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo valor: ");
                    double valor2 = double.Parse(Console.ReadLine());
                    if (operação == "S")
                    {
                        calc.Encerrada = true;
                    }
                    else
                    {
                        new Calculadora(valor1, valor2, operação);
                    }

                    Console.WriteLine("Resultado: " + calc.Resultado());
                }
                catch(DomainException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception r)
                {
                    Console.Clear();
                    Console.WriteLine(r.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

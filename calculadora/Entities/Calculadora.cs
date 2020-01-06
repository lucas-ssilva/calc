using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora.Entities
{
    class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operacao { get; set; }
        public bool Encerrada { get; set; }

        public Calculadora(double valor1, double valor2, string operacao)
        {
            Valor1 = valor1;
            Valor2 = valor2;
            Operacao = operacao;
            Encerrada = false;
        }
        public Calculadora() { }

        public static void validacoes(string validar)
        {
            if (validar != "+" || validar != "-" || validar != "*" || validar != "/" || validar != "S" )
            {
                throw new DomainException("Operação Invalida, tente novamente");
            }
            else
            {
                return null;
            }
        }

        public double Resultado()
        {
            if (Operacao == "+")
            {
                return Valor1 + Valor2;
            }
            else if(Operacao == "-")
            {
                return Valor1 - Valor2;
            }
            else if(Operacao == "*")
            {
                return Valor1 * Valor2;
            }
            else
            {
                return Valor1 / Valor2;
            }
        }

    }
}

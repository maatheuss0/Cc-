using System;

namespace Calculadora_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int AnoAtual, AnoNascimento, Idade, Semanas;

            Console.WriteLine("Calculadora de idade iniciada!!!\n");

            Console.WriteLine("Qual é seu ano de nascimento?: ");
            AnoNascimento = int.Parse(Console.ReadLine());
            AnoAtual = DateTime.Now.Year;

            Idade = AnoAtual - AnoNascimento;
            Semanas = Idade * 52;

            Console.WriteLine("\nSua idade atual é " + Idade + " anos.");
            Console.WriteLine("\nSua idade em semana é " + Semanas + " semanas. ");

        }
    }
}

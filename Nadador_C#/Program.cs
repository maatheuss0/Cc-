using System;

namespace Categoria_Nadadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade;

            Console.WriteLine("Categorizador Iniciado!!!\n");
            Console.WriteLine("Escreva sua Idade ");
            Idade = int.Parse(Console.ReadLine());

            if(Idade >= 5 && Idade <= 7){
                Console.WriteLine("Você esta na 'CATEGORIA INFANTIL A'");
            }
            else if (Idade >= 8 && Idade <= 10){
            Console.WriteLine("Você está na 'CATEGORIA INFANTIL B'");
            }
            else if (Idade >= 11 && Idade <= 13){
            Console.WriteLine("Você está na 'JUVENIL A'");
            }
            else if (Idade >= 14 && Idade <= 17){
            Console.WriteLine("Você está na 'JUVENIL B'");
            }
            else if (Idade >= 18){
            Console.WriteLine("Você está na 'SÊNIOR'");
            }    
        }
    }
}

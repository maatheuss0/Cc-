using System;

namespace C_
{
    class IdadeEmDias 
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            double horas, minutos;

            Console.WriteLine("Conversor de anos iniciado!!!\n");
            Console.Write("Diga a sua idade: ");
            anos = int.Parse(Console.ReadLine());

            meses = anos * 12;
            dias = anos * 365;
            horas = dias * 24;
            minutos = horas * 60;

            Console.WriteLine("Sua idade em meses: " + meses + " meses");
            Console.WriteLine("Sua idade em dias: " + dias + " dias");
            Console.WriteLine("Sua idade em horas: " + horas + " horas");
            Console.WriteLine("Sua idade em minutos: " + minutos + " minutos");
        }
    }
}

using System;

namespace DIO.Series
{
    internal class ConsoleObterAnoSerie
    {
        public int consoleObterAnoSerie()
        {

            Console.Write("****** FLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;

        }

        public static implicit operator int(ConsoleObterAnoSerie v)
        {

            Console.Write("****** FLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;
            
        }
    }
}
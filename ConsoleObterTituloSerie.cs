using System;

namespace DIO.Series
{
    internal class ConsoleObterTituloSerie
    {
        public string consoleObterTituloSerie()
        {

            Console.Write("****** FLIX ****** Digite o título da série: ");  
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;

        }
        public static implicit operator string(ConsoleObterTituloSerie v)
        {

            Console.Write("****** FLIX ****** Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;
            
        }
    }
}
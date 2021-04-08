using System;

namespace DIO.Series
{
    internal class ConsoleListarGeneroSerie
    {
        public ConsoleListarGeneroSerie()
        {

            Console.WriteLine("****** FLIX ****** Lista de generos: ");
            Console.WriteLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

        }
    }
}
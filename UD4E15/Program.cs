using System;

namespace UD4E15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 8;

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es divisible entre 2");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no es divisible entre 2");
            }
        }
    }
}

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conLista, conNumeroLista = 0;

            do 
            {
                conNumeroLista++;
                conLista = 0;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    conLista++;
                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad del grupo " + conNumeroLista + " es: " + conLista);
            }
            while (n >= 0);
        }
    }
}

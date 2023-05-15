using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con, conPrimo = 0;
            
            for (int x = 0; x < 10; x++) {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                con = 0;
                for (int y = 1; y <= n; y++) {
                    if (n % y == 0) 
                        con++;
                }
                if (con == 2)
                    conPrimo++;
            }

            Console.WriteLine("Hay " + conPrimo + " números primos");

        }
    }
}

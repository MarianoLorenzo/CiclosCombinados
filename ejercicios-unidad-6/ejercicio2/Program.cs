using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conImpar, conLote, porcImpares, maxPorcImpares = 0, nGrupo = 0, min, conOrdenados = 0;
            bool banderaOrdenados;

            for (int x = 0; x < 5; x++) 
            {
                banderaOrdenados = true;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                min = n;
                conLote = 0;
                conImpar = 0;

                while (n != 0) 
                {
                    conLote++;

                    if (n % 2 != 0)
                        conImpar++;

                    if (n <= min)
                        min = n;
                    else 
                        banderaOrdenados = false;        

                    Console.WriteLine("Ingrese un número: ");
                    n = int.Parse(Console.ReadLine());
                }
                porcImpares = conImpar / conLote * 100;

                if (porcImpares > maxPorcImpares) 
                {
                    maxPorcImpares = porcImpares;
                    nGrupo = x;
                }

                if (banderaOrdenados)
                    conOrdenados++;
            }

            Console.WriteLine("El número de grupo con mayor porcentaje de impares es: " + (nGrupo + 1));
            Console.WriteLine("La cantidad de grupos ordenados es: " + conOrdenados);
            
            
        }
    }
}

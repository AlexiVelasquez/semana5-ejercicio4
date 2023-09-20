using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace semana5_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("******************");
            Console.WriteLine("1: MOSTRAR SECUENCIAS DE 3");
            Console.WriteLine("2: HALLAR EL PROMEDIO DE NOTAS ");
            Console.WriteLine("3: MOSTRAR LA TABLA DE UN NÚMERO");
            Console.Write("->");int opcion=int.Parse(Console.ReadLine());
            

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("INGRESE EL NÚMERO MAXIMO:");
                        int nmax=int.Parse(Console.ReadLine());

                        int secuencia = 0;

                        Console.WriteLine("La secuencia de números múltiplos de 3 hasta " + nmax + " es:");

                        for (int i = 3; i <= nmax; i += 3)
                        {
                            Console.Write(i);

                            if (i + 3 <= nmax)
                            {
                                Console.Write(", ");
                            }
                        }


                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("INGRESE EL NÚMERO DE NOTAS:");
                        int notas = int.Parse(Console.ReadLine());

                        int promedio = 0;
                        int sumas = 0;
                        for (int i = 1; i <= notas; i++)
                        {

                            Console.Write("NOTA "+i+": ");
                            int npar=int.Parse(Console.ReadLine());
                            sumas= sumas+npar;
                            promedio = sumas / notas;

                        }
                        Console.WriteLine("EL PROMEDIO ES:"+promedio);
                    }
                    break;
                case 3:
                    {

                        Console.Write("INGRESE EL NUMERO:");
                        int numero =int.Parse(Console.ReadLine());

                        int multi = 0;

                        for (int i = 1; i<=10; i++)
                        {

                            multi = numero * i;
                            Console.WriteLine(numero+"x"+i+"="+multi);


                        }
                                                                     

                    }
                    break;
                case 4:
                    {

                        Console.WriteLine("OPCION NO VALIDA");
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static double Raiz(int a)
        {
            return Math.Sqrt(a);
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static int celfar(int a)
        {
            return ((9 * a) / 5) + 32;
        }
        static int farcel(int a)
        {
            return (5 * (a - 32)) / 9;
        }

        static void Main(string[] args)
        {

            Console.Title = "Procedimientos y funciones";
            String opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el numero de la opcion que desea ejecutar");
                Console.WriteLine("[1] suma de 2 numeros");
                Console.WriteLine("[2] imprimir la raiz cuadrada");
                Console.WriteLine("[3] resta de 2 numeros");
                Console.WriteLine("[4] multiplicacion de 2 numeros");
                Console.WriteLine("[5] division de 2 numeros");
                Console.WriteLine("[6] 10 numeros primos");
                Console.WriteLine("[7] de Celsius a Farenheit");
                Console.WriteLine("[8] de Farenheit a Celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("SUMA");
                        Console.WriteLine("Ingrese valor de n1:");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese valor de n2:");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        int suma = Suma(n1, n2);

                        Console.WriteLine("La Suma es {0}", suma);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("RAIZ CUADRADA");
                        Console.WriteLine("Ingrese valor de n:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La raiz es {0}", Raiz(n));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Resta");
                        Console.WriteLine("Ingrese valor de n1:");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese valor de n2:");
                        int r2 = Convert.ToInt32(Console.ReadLine());

                        int resta = Resta(r1, r2);

                        Console.WriteLine("La Resta es {0}", resta);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Multiplicacion");
                        Console.WriteLine("Ingrese valor de n1:");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese valor de n2:");
                        int m2 = Convert.ToInt32(Console.ReadLine());

                        int multiplicacion = Multiplicacion(m1, m2);

                        Console.WriteLine("La Mukltiplicacion es {0}", multiplicacion);
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Division");
                        Console.WriteLine("Ingrese valor de n1:");
                        int d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese valor de n2:");
                        int d2 = Convert.ToInt32(Console.ReadLine());

                        int division = Division(d1, d2);

                        Console.WriteLine("La Division es {0}", division);
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los 10 primeros numeros primos son:");
                        int cont = 0;
                        for (int i = 2; i <= 30; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    cont = cont + 1;
                                }
                            }

                            if (cont <= 2)
                            {
                                Console.WriteLine(i);
                            }
                            cont = 0;
                        }

                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Celsius a Farenheit");
                        Console.WriteLine("Ingrese el valor en Celsius para transformar a Farenheit:");
                        int c1 = Convert.ToInt32(Console.ReadLine());

                        int celtofar = celfar(c1);

                        Console.WriteLine("El valor en Farenheit es {0}", celtofar);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Farenheit a Celsius");
                        Console.WriteLine("Ingrese el valor en Farenheit para transformar a Celsius:");
                        int f1 = Convert.ToInt32(Console.ReadLine());

                        int fartocel = farcel(f1);

                        Console.WriteLine("El valor en Celsius es {0}", fartocel);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}

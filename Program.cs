using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Tarea_3
{
    internal class Program
    {
        static int opcion = 0;  // global
        static float num1 = 0, num2 = 0;
        static void menu()
        {
            int opcion = 0;   // variable local 

            do
            {

                Console.WriteLine("1-Suma");
                Console.WriteLine("2-resta");
                Console.WriteLine("3-Multiplicacio");
                Console.WriteLine("4-Division");
                Console.WriteLine("5-Salir");
                Console.WriteLine("Digite una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                if (opcion >= 1 && opcion <= 4) {   // if para que no se deba solicitar en cada caso y no pregunte los numeros en 5
                    Solicitar();  
                }
                   
                switch (opcion)
                {

                    case 1:
                        //Solicitar(); // comentado y subido arriba a la linea 27
                        Console.WriteLine($"Suma: {suma()}");
                        break;
                    case 2:
                        //Solicitar();// comentado y subido arriba a la linea 27
                        resta();
                        break;
                    case 3:
                       // Solicitar(); // comentado y subido arriba a la linea 27
                        Console.WriteLine($"Multiplicacion: {multiplicar(num1, num2)}");

                        break;
                    case 4:
                        // Solicitar();  // comentado y subido arriba a la linea 27
                        dividir(num1, num2);
                        break;
                    case 5: break;
                    default:
                        break;
                }

            } while (opcion != 5);

        }


        static float suma()
        {
            return num1 + num2;
        }

        static float multiplicar(float v1, float v2)
        {
            return (v1 * v2);

        }
        static void dividir(float v1, float v2)
        {
            Console.WriteLine($"Dividir: {v1 / v2} ");
        }

        static void resta()
        {
            float total = num1 - num2;
            Console.WriteLine($"Resta: {total} ");
        }
        static void Solicitar()
        {
            Console.WriteLine("Digite un numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero:");
            num2 = float.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            //opcion = 10;
            menu();



        }
    }
}

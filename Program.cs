using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
            //si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número 
            //es igual a cero.

            //Paso 0: Crear Variables
            int NUM;

            //Paso 1: Pedir Numero
            Console.WriteLine("Ingrese un numero: ");
            NUM = int.Parse(Console.ReadLine());

            //Paso 2: Condiciones
            if(NUM > 0)
                Console.WriteLine("POSITIVO");
            if(NUM < 0)
                Console.WriteLine("NEGATIVO");
            if(NUM == 0)
                Console.WriteLine("CERO");

            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}

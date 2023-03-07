// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio5
{
    class Program
    {   
        static void Main(string[] args)
        {   
            int tamanio;
            Console.Write("Introdusca el tamanio del vector: ");
            tamanio = int.Parse(Console.ReadLine());
            Console.Write("El tamanio del vector es: " + tamanio + "\n\n");
            int[] vector = new int[tamanio];

            for(int i  = 0 ; i < tamanio ; i++){
                Console.Write("Introdusca el valor "+ (i+1) + " del vector: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            
            int contador = 0;
            foreach( int item in vector){
                if(item > 100){
                    contador++;
                }
            }
            System.Console.WriteLine("\nLos valores mayor a 100 del vector son: " + contador);
            Console.ReadKey();
        }
    }
}

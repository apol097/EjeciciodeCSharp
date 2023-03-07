// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {   
        static void Main(string[] args)
        {   
            int tamanio;
            Console.Write("Introdusca el tamanio del vector: ");
            tamanio = int.Parse(Console.ReadLine());
            Console.Write("El tamanio del vector es: " + tamanio);
            int[] vector = new int[tamanio];

            for(int i  = 0 ; i < tamanio ; i++){
                Console.WriteLine("\nIntrodusca el valor "+ (i+1) + " del vector: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Los valores mayor a 100 del vector son: ");

            foreach( int item in vector){
                if(item > 100){
                    int index = Array.IndexOf(vector, item);
                    Console.Write($" valor {index + 1} : {item} ");
                }
            }
            Console.ReadKey();
        }
    }
}

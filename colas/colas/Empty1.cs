/*
 * Creado por SharpDevelop.
 * Usuario: Noemy
 * Fecha: 10/09/2016
 * Hora: 21:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();

            cola.Enqueue("Perro");
            cola.Enqueue("Gato");
            cola.Enqueue("Loro");
            cola.Enqueue("Tigre");
            cola.Enqueue("Leon");
           
         

            for (int i = 0; i < 1; i++)
            {              
                Console.WriteLine("Elementos que se encuentran en la cola: " + cola.Count);
                Console.WriteLine("");
              
                Console.WriteLine("Elemento retirado de la cola: " +cola.Dequeue());
                Console.WriteLine("elemento que queda en la cola es: " +cola.Peek());
                Console.WriteLine("");
                Console.WriteLine("");
            }
          
            Console.WriteLine("Elementos que se encuentran en la cola: " + cola.Count);                      
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace maze
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Maze maze = new Maze();
            int size;
            while (true)
            {
                Console.Write("Ingrese el tamaño del laberinto (mayor que 3): " );
                size = int.Parse(Console.ReadLine());

                // Asegúrate de que el tamaño sea mayor que 3
                if (size <= 3) 
                {
                    Console.WriteLine("El tamaño debe ser mayor que 3." );
                    continue; 
                }
                
                maze.Generator(size);
                maze.Print();
            }
        }
    }
}

        
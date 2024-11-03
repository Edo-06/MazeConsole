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
                string? input = Console.ReadLine();

                if(int.TryParse(input, out size))
                {
                    size = int.Parse(input);
                    if(size < 3)
                    {
                        Console.WriteLine("La entrada debe ser un numero mayor que 3." );
                    }
                }
                else
                {
                    Console.WriteLine("La entrada debe ser un numero." );
                    continue; 
                }          
                
                maze.Generator(size);
                maze.Print();
            }
        }
    }
}

        
using System;
using System.Collections.Generic;

namespace maze
{
    class Program
    {
        static List<int[]> usedcells = new List<int[]>();
        static Random random = new Random();
        static int size;
        static int[,] mazee;

        static void Main(string[] args)
        {
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

                Matriz();
                
                usedcells.Add(new int[] {random.Next(1, size-1), random.Next(1, size-1) });
                MazeGenerator();
                Print();
            }
        }

        static void MazeGenerator()
        {
            mazee[usedcells[0][0], usedcells[0][1]] = 1; 
            int[] cell;
            List<int[]> neighbords = new List<int[]>();
            int row, col, newrow, newcol, indice;

            while (usedcells.Count > 0)
            {
                
                cell = usedcells[usedcells.Count - 1];
                row = cell[0];
                col = cell[1];
                neighbords.Clear(); 

                
                if (row >= 2 && mazee[row - 2, col] == 0)
                    neighbords.Add(new int[] { row - 2, col });
                if (col >= 2 && mazee[row, col - 2] == 0)
                    neighbords.Add(new int[] { row, col - 2 });
                if (row <= size - 3 && mazee[row + 2, col] == 0)
                    neighbords.Add(new int[] { row + 2, col });
                if (col <= size - 3 && mazee[row, col + 2] == 0)
                    neighbords.Add(new int[] { row, col + 2 });

                if (neighbords.Count > 0)
                {
                    
                    indice = random.Next(0, neighbords.Count-1);
                    newrow = neighbords[indice][0];
                    newcol = neighbords[indice][1];
                    //if (newrow != 0 && newcol != 0) 
                    mazee[newrow, newcol] = 1;
                    //if ((row + newrow) / 2 !=0 && (col + newcol) / 2 != 0)
                    mazee[(row + newrow) / 2, (col + newcol) / 2] = 1;

                    usedcells.Add(new int[] { newrow, newcol });
                }
                else
                {
                    usedcells.RemoveAt(usedcells.Count - 1);
                }
            }
        }

        static void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mazee[i, j]==0 ? "██" : "  ");
                }
                Console.WriteLine();
            }
        }

        static void Matriz()
        {
            mazee = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mazee[i, j] = 0;
                }
            }
        }
    }
}



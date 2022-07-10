using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar_Algorithm
{
    static class GraphUtils
    {
        public static int[,] ReadAdjMatrix(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int[,] adjMatrix = new int[lines.Length, lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Trim();
                    string[] entries = lines[i].Split(" ");

                    for (int j = 0; j < entries.Length; j++)
                    {
                        int value = 0;
                        int.TryParse(entries[j], out value);
                        adjMatrix[i, j] = value;
                    }
                }

                return adjMatrix;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return new int[1, 1];
            }
            
        }

        public static LinkedList<Edge>[] AdjMatrixToLists(int[,] matrix)
        {
            LinkedList<Edge>[] adjLists = new LinkedList<Edge>[matrix.GetLength(0)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                adjLists[i] = new LinkedList<Edge>();
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) continue;

                    adjLists[i].AddLast(new Edge(i, j, matrix[i, j]));
                }
            }

            return adjLists;
        }
        
    }
}

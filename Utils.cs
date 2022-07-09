using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar_Algorithm
{
    static class Utils
    {
        public static void LogMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void LogGraph(LinkedList<Edge>[] adjLists)
        {
            for(int i = 0; i < adjLists.Length; i++)
            {
                Console.Write($"{i}: ");

                foreach(Edge edge in adjLists[i])
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"{edge.To}");
                    Console.ResetColor();
                    Console.Write("-");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"{edge.Weight} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public static void LogPath(LinkedList<int> path)
        {
            foreach(int v in path)
            {
                if(v != path.First.Value)
                {
                    Console.Write($" -> {v}");
                    continue;
                }

                Console.Write(v);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar_Algorithm.Matrices
{
    public class PathFinder
    {
        public LinkedList<Edge>[] Graph { get; private set; }

        public PathFinder(LinkedList<Edge>[] grap)
        {
            Graph = grap;
        }

        public LinkedList<int> FindPath(int startNode, int endNode)
        {
            int[] previous = new int[Graph.Length];
            Dictionary<int, int> unexplored = new Dictionary<int, int>();

            for(int i = 0; i < Graph.Length; i++)
            {
                unexplored.Add(i, i == startNode ? 0 : int.MaxValue);
            }

            while (unexplored.Keys.Contains(endNode))
            {
                int v = unexplored.MinBy(kvp => kvp.Value).Key;

                foreach(Edge edge in Graph[v])
                {
                    if (unexplored.ContainsKey(edge.To) && unexplored[v] + edge.Weight < unexplored[edge.To])
                    {
                        unexplored[edge.To] = unexplored[v] + edge.Weight;
                        previous[edge.To] = v;
                    }
                }

                unexplored.Remove(v);
            }

            // reconstruct path

            int current = endNode;
            LinkedList<int> path = new LinkedList<int>();
            path.AddLast(current);

            while(current != startNode)
            {
                current = previous[current];
                path.AddFirst(current);
            }

            return path;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar_Algorithm
{
    public struct Edge
    {
        public int Weight { get; private set; }
        public int From { get; private set; }
        public int To { get; private set; }
        public Edge(int from, int to, int weight = 1)
        {
            Weight = weight;
            From = from;
            To = to;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Shortest_Path_Graph
{
    class Pair
    {
        public int Dest, Weight;

        public Pair(int Dest, int Weight)
        {
            this.Dest = Dest;
            this.Weight = Weight;
        }
    }
}

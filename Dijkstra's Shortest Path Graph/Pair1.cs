using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Shortest_Path_Graph
{
    class Pair1
    {
        public int Source;
        public int Destination;
        public int Weight;

        public Pair1( int Destination, int Weight)
        {
            this.Destination = Destination;
            this.Weight = Weight;
        }
    }
}

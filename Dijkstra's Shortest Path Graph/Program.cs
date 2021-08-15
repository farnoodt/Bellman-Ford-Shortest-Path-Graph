using System;

namespace Dijkstra_s_Shortest_Path_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph1 g = new Graph1(6);
            g.AddEdge(1, 2, 1);
            g.AddEdge(2, 3, 7);
            g.AddEdge(2, 4, -2);
            g.AddEdge(1, 3, 8);
            g.AddEdge(1, 4, 9);
            g.AddEdge(3, 4, 3);
            g.AddEdge(2, 5, 3);
            g.AddEdge(4, 5, -3);

            g.ShortestPath(1);

        }
        
    }                
}

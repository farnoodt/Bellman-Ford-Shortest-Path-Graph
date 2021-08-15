using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Shortest_Path_Graph
{
    class Graph1
    {
        List<List<Pair1>> MyGraph = new List<List<Pair1>>();
        int Nodes;
        public Graph1(int V)
        {
            this.Nodes = V;
            for (int i = 0; i < Nodes; i++)
                MyGraph.Add(new List<Pair1>());
        }

        public void AddEdge(int Source, int Destination, int Weight)
        {
            MyGraph[Source].Add(new Pair1(Destination, Weight));
        }
        public void ShortestPath(int Source)
        {
            bool[] IsVisited = new bool[Nodes+1];
            int[] path = new int[Nodes + 1];
            Queue<int> Q = new Queue<int>();

            for (int i = 0; i < Nodes + 1; i++)
                path[i] = int.MaxValue;
            Q.Enqueue(Source);
            path[Source] = 0;

            while (Q.Count != 0)
            {
                int current = Q.Dequeue();
                List<Pair1> Node = MyGraph[current];

                foreach (var child in Node)
                {
                    int Dest = child.Destination;
                    int Weight = child.Weight;
                    if(path[Dest] > path[current] + Weight)
                    {
                        path[Dest] = path[current] + Weight;
                        if (!IsVisited[Dest])
                        {
                            IsVisited[Dest] = true;
                            Q.Enqueue(Dest);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" , ", path));
        }

    }
}

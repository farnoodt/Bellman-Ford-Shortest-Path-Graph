using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Shortest_Path_Graph
{
    class Graph
    {
        int V; //No. of verteices
        List<List<Pair>> MyGraph = new List<List<Pair>>();
        public Graph(int V)
        {
            this.V = V;
            for (int i = 0; i < 100; i++)
            {
                MyGraph.Add(new List<Pair>());
            }

        }

        public void AddEdge(int Source, int Destination, int Weight)
        {
            MyGraph[Source].Add(new Pair(Destination, Weight));
        }

        public void ShortestPath(int Source, int Vertex)
        {
            int[] shortPath = new int[Vertex+1];
            bool[] IsVisited = new bool[Vertex + 1];
            Queue<int> Q = new Queue<int>();

            for (int i = 0; i < shortPath.Length; i++)
            {
                shortPath[i] = int.MaxValue;
            }

            shortPath[Source] = 0;
            IsVisited[Source] = true;
            Q.Enqueue(Source);

            while (Q.Count != 0)
            {
                int current = Q.Dequeue();

                List<Pair> CurrentPair = new List<Pair>();
                CurrentPair = MyGraph[current];
                foreach (var child in CurrentPair)
                {
                    int to = child.Dest;
                    int weight = child.Weight;

                    if (shortPath[to] > shortPath[current] + weight)
                    {
                        shortPath[to] = shortPath[current] + weight;
                        if(!IsVisited[to])
                        {
                            IsVisited[to] = true;
                            Q.Enqueue(to);
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(" , ", shortPath));

        }
    }
}

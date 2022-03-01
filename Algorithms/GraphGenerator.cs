using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GraphGenerator
    {
        public Graph Generate(int size)
        {
            List<Node> Nodes = new List<Node>();
            List<Arc> Arcs = new List<Arc>();

            Node Start = new Node(0, false);
            Nodes.Add(Start); // Initial node

            Random Random = new Random();

            for (int i = 1; i < size; i++)
            {
                Node N = new Node(i, false);
                Nodes.Add(N);

                if (Random.Next(1, 3) == 1)
                {
                    Arc A = new Arc(Nodes[i - 1], Nodes[i]);
                    Arcs.Add(A);
                }

                else
                {
                    Arc A = new Arc(Nodes[i - 1], Nodes[i]);
                    Arcs.Add(A);

                    Arc B = new Arc(Nodes[i - 1], Nodes[Random.Next(1, Nodes.Count - 1)]);
                    Arcs.Add(B);
                }
            }

            Graph Result = new Graph(Nodes, Arcs);

            return Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Graph
    {
        private List<Node> _Nodes { get; set; }

        private List<Arc> _Arcs { get; set; }

        public List<Node> Nodes
        {
            get
            {
                return _Nodes;
            }
        }

        public List<Arc> Arcs
        {
            get
            {
                return _Arcs;
            }
        }

        public Graph(List<Node> Nodes, List<Arc> Arcs)
        {
            this._Nodes = new List<Node>(Nodes);
            this._Arcs = new List<Arc>(Arcs);
            AddNeighbors();
        }

        private void AddNeighbors()
        {
            foreach (Node Node in _Nodes)
            {
                foreach (Arc Arc in _Arcs)
                {
                    if (Node.ID == Arc.Outgoing.ID)
                    {
                        Node.Neighbors.Add(Arc);
                    }
                }
            }
        }

        public void Display()
        {
            foreach (Node N in Nodes)
            {
                Console.WriteLine($"Node: {N.ID}");
            }

            foreach (Arc A in Arcs)
            {
                int i = 0;
                Console.WriteLine($"Arc: {i} {A.Show()}");
                i++;
            }
        }
    }
}

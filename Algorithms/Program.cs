using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Graph data
            List<Node> Nodes = new List<Node>();
            Nodes.Add(new Node(1, false));
            Nodes.Add(new Node(2, false));
            Nodes.Add(new Node(3, false));
            Nodes.Add(new Node(4, false));
            Nodes.Add(new Node(5, false));
            Nodes.Add(new Node(6, false));
            Nodes.Add(new Node(7, false));
            Nodes.Add(new Node(8, true));
            Nodes.Add(new Node(9, false));
            Nodes.Add(new Node(10, false));
            Nodes.Add(new Node(11, false));

            List<Arc> Arcs = new List<Arc>();
            Arcs.Add(new Arc(Nodes[0], Nodes[1]));
            Arcs.Add(new Arc(Nodes[0], Nodes[2]));
            Arcs.Add(new Arc(Nodes[0], Nodes[8]));
            Arcs.Add(new Arc(Nodes[1], Nodes[3]));
            Arcs.Add(new Arc(Nodes[1], Nodes[4]));
            Arcs.Add(new Arc(Nodes[10], Nodes[6]));
            Arcs.Add(new Arc(Nodes[8], Nodes[9]));
            Arcs.Add(new Arc(Nodes[3], Nodes[5]));
            Arcs.Add(new Arc(Nodes[4], Nodes[5]));
            Arcs.Add(new Arc(Nodes[5], Nodes[7]));
            Arcs.Add(new Arc(Nodes[6], Nodes[7]));
            Arcs.Add(new Arc(Nodes[9], Nodes[7]));
            Arcs.Add(new Arc(Nodes[2], Nodes[10]));

            Graph Graph = new Graph(Nodes, Arcs);
            
            GenericSearch Search = new GenericSearch();

            //Debugging
            GraphGenerator graphGenerator = new GraphGenerator();
            Graph Test = graphGenerator.Generate(100);
            Test.SetGoalState(99);
            //Test.Display();
            Search.RunDebug(Test, Test.Nodes[0], Test.Nodes[99]);
        }
    }
}

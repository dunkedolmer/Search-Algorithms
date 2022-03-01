using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GenericSearch
    {    
        // Constructor
        public GenericSearch()
        {
            
        }

        // Methods
        public List<Arc> Run(Graph G, Node S, Node goal)
        {
            List<Arc> Frontier = new List<Arc>(); // Set of paths
            Arc Start = new Arc(null, S);
            Frontier.Add(Start);

            while (Frontier.Count > 0)
            {
                Arc current = Frontier.First<Arc>();

                if (Goal(current.Incoming) && current.Incoming.ID == goal.ID)
                {
                    return Path(Start, current); // Return path
                }

                foreach (Arc Neighbor in current.Incoming.Neighbors)
                {
                    Frontier.Add(Neighbor); // Expand frontier
                    Neighbor.Outgoing.Previous.Add(current); // For backtracking
                }

                Frontier.Remove(current);
            }

            Console.WriteLine("No solution");
            return null; // Return if no solution found
        }

        public bool Goal(Node n)
        {
            if (n.Goal)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public List<Arc> Path(Arc Start, Arc Goal)
        {
            List<Arc> Result = new List<Arc>(); // Path
            Arc Current = Goal;

            while (Current != Start)
            {
                Result.Add(Current);

                Current = Current.Outgoing.Previous[0];
            }

            Result.Reverse();

            return Result;
        }

        public void RunDebug(Graph G, Node S, Node goal)
        {
            int count = 1;

            foreach (Arc A in Run(G,S,goal))
            {
                Console.WriteLine($"Step: {count}   {A}");
                count++;
            }
        }
    }
}

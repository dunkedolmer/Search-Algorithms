using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        private int _ID { get; set; }

        private bool _Goal { get; set; }

        public int ID
        {
            get
            {
                return _ID;
            }
        }

        public bool Goal
        {
            get
            {
                return _Goal;
            }
        }

        public List<Arc> Previous { get; set; }
        
        public List<Arc> Neighbors { get; set; }
               

        public Node(int ID, bool Goal)
        {
            this._ID = ID;
            this._Goal = Goal;
            this.Previous = new List<Arc>();
            this.Neighbors = new List<Arc>();
        }

        public override string ToString()
        {
            return _ID.ToString();
        }
    }
}

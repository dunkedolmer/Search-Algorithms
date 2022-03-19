using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Arc
    {
        public Node Outgoing { get; }

        public Node Incoming { get; }

        public int Cost { get; set; }

        public Arc(Node Outgoing, Node Incoming)
        {
            this.Outgoing = Outgoing;
            this.Incoming = Incoming;
        }

        public string Show()
        {
            return $"Outgoing: {Outgoing}, Incoming: {Incoming}";
        }

        public override string ToString()
        {
            return $"Outgoing: {Outgoing.ToString()} Incoming: {Incoming.ToString()}";
        }
    }
}

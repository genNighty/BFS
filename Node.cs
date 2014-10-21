using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Node
    {
        public string label;
        public bool visited = false;
        public Node(string l)
        {
            this.label = l;
        }
    }
}

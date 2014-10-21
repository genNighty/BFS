using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Graph : MakeMagic
    {
        public Node rootNode;
        public ArrayList nodes = new ArrayList();
        public ArrayList prints = new ArrayList();
        public int[,] adjMatrix;//Edges will be represented as adjacency Matrix
        int i = 0;

        MakeMagic magia = new MakeMagic();

        string name = "_" + DateTime.Now.ToString("yyyy-MM-dd-HH.mm.ss.fff") + ".txt";


        public void setRootNode(Node n)
        {
            this.rootNode = n;
        }

        public Node getRootNode()
        {
            return this.rootNode;
        }

        public void addNode(Node n)
        {
            nodes.Add(n);
            prints.Add(n.label);
        }

        public void connectNode(Node start, Node end)
        {
            if (adjMatrix == null)
            {
                size = nodes.Count;
                adjMatrix = new int[size, size];
            }

            int startIndex = nodes.IndexOf(start);
            int endIndex = nodes.IndexOf(end);
            adjMatrix[startIndex, endIndex] = 1;
            if (skierowany == 0)
            {
                adjMatrix[endIndex, startIndex] = 1;
            }
        }


        private Node getUnvisitedChildNode(Node n)
        {
            int index = nodes.IndexOf(n);
            int j = 0;
            while (j < size)
            {
                if (adjMatrix[index, j] == 1 && ((Node)nodes[j]).visited == false)
                {
                    return (Node)nodes[j];
                }
                j++;
            }
            return null;
        }


        public void bfs()
        {
            printMatrix(prints);
            Queue q = new Queue();
            q.Enqueue(this.rootNode);
            printNode(this.rootNode);
            rootNode.visited = true;
            while (q.Count != 0)
            {
                Node n = (Node)q.Dequeue();
                Node child = null;
                while ((child = getUnvisitedChildNode(n)) != null)
                {
                    child.visited = true;
                    printNode(child);
                    q.Enqueue(child);
                }
            }
            clearNodes();
            Console.WriteLine("\n\nZapisano plik " + name);
        }


        private void clearNodes()
        {
            int i = 0;
            while (i < size)
            {
                Node n = (Node)nodes[i];
                n.visited = false;
                i++;
            }
        }


        private void printNode(Node n)
        {
            StreamWriter file = File.AppendText(name);

            Console.Write(n.label);
            file.Write(n.label);
          
            if(i < size - 1)
            {
                Console.Write(" -> ");
                file.Write(" -> ");
                i++;
            }

            file.Close();
        }


        public void printMatrix(ArrayList prints)
        {
            Console.Write("   ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(prints[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                Console.Write(prints[i] + "  ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }
    }
}

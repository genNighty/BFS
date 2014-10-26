using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class MakeMagic
    {
        string nazwa;
        string line;
        public int skierowany;
        public int size;
        string wp;
        string wk;
        string w;

        public void mayMagicBegin()
        {
            Console.WriteLine("Podaj ścieżkę bezwzględną pliku");

            nazwa = Console.ReadLine();
            Console.WriteLine();
            StreamReader x = new StreamReader(nazwa, Encoding.UTF8);
            string start = x.ReadLine();
            Node startowy = new Node(start);

            size = Int32.Parse(x.ReadLine());
            skierowany = Int32.Parse(x.ReadLine());

            List<string>check = new List<string>();

            Graph g = new Graph();
            g.setRootNode(startowy);

            Console.Write(size);
            Console.ReadKey();

            line = x.ReadLine();
            while (line != null)
            {
                wp = line.Substring(0, line.IndexOf(" "));
                line = line.Substring(line.IndexOf(" ") + 1);
                wk = line.Substring(0, line.IndexOf(" "));
                line = line.Substring(line.IndexOf(" ") + 1);
                w = line;

                Node node = new Node(wp);
                Node node2 = new Node(wk);
            
                if (!check.Contains(wp))
                {
                    check.Add(wp);
                    g.addNode(node);
                }
                if (!check.Contains(wk))
                {
                    check.Add(wk);
                    g.addNode(node2);
                }

                foreach (string s in check)
                {
                    Console.Write("LISTA NODOW: " + s + "\n");
                }

                g.connectNode(node, node2);
                
                line = x.ReadLine();
                Console.ReadKey();
            }

            
        }
    }
}

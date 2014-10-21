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
        string start;
        public int skierowany;
        public int size;
        string wp;
        string wk;
        string w;

        public void mayMagicBegin()
        {
            Console.WriteLine("Podaj ścieżkę pliku");

            nazwa = Console.ReadLine();
            Console.WriteLine();
            StreamReader x = new StreamReader(nazwa, Encoding.UTF8);
            start = x.ReadLine();
            size = Int32.Parse(x.ReadLine());
            skierowany = Int32.Parse(x.ReadLine());

            line = x.ReadLine();
            while (line != null)
            {
                wp = line.Substring(0, line.IndexOf(" "));
                line = line.Substring(line.IndexOf(" ") + 1);
                wk = line.Substring(0, line.IndexOf(" "));
                line = line.Substring(line.IndexOf(" ") + 1);
                w = line;

                Console.WriteLine(wp + " " + wk + " " + w);
                
                line = x.ReadLine();
            }

            
        }
    }
}

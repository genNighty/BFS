using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    class Program : Graph
    {
        static void Main(string[] args)
        {
            MakeMagic magic = new MakeMagic();

            magic.mayMagicBegin();

           /* Node nA = new Node('A');
            Node nB = new Node('B');
            Node nC = new Node('C');
            Node nD = new Node('D');
            Node nE = new Node('E');
            Node nF = new Node('F');
            Node nG = new Node('G');
            Node nH = new Node('H');
            Node nI = new Node('I');

            Graph g=new Graph();
		    g.addNode(nA);
		    g.addNode(nB);
		    g.addNode(nC);
		    g.addNode(nD);
		    g.addNode(nE);
		    g.addNode(nF);
            g.addNode(nG);
            g.addNode(nH);
            g.addNode(nI);

		    g.setRootNode(nA);
		
		    g.connectNode(nA,nB);
		    g.connectNode(nA,nG);
            g.connectNode(nA,nF);	
		    g.connectNode(nB,nG);
		    g.connectNode(nB,nC);
		    g.connectNode(nC,nH);
            g.connectNode(nC,nD);
            g.connectNode(nD, nH);
            g.connectNode(nD, nE);
            g.connectNode(nE, nI);
            g.connectNode(nE, nF);
            g.connectNode(nF, nI);
            g.connectNode(nH, nI);
            g.connectNode(nG, nH);
            g.connectNode(nG, nI);*/


            Node n1 = new Node("1");
            Node n2 = new Node("2");
            Node n3 = new Node("3");
            Node n4 = new Node("4");
            Node n5 = new Node("5");
            Node n6 = new Node("6");

            Graph g = new Graph();
            g.addNode(n1);
            g.addNode(n2);
            g.addNode(n3);
            g.addNode(n4);
            g.addNode(n5);
            g.addNode(n6);

            g.setRootNode(n1);

            g.connectNode(n1, n2);
            g.connectNode(n1, n3);
            g.connectNode(n2, n4);
            g.connectNode(n2, n5);
            g.connectNode(n3, n4);
            g.connectNode(n3, n6);
            g.connectNode(n4, n1);


		    Console.WriteLine("\nBFS WYGLADA TAK O\n");
		    g.bfs();
            Console.ReadKey();
        }
    }
}

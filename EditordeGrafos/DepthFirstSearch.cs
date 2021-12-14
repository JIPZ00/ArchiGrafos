using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditordeGrafos
{
    public partial class DepthFirstSearch : Form
    {
        int depth; //Auxiliar para profundidad (para saber si es raiz o no)
        int noArb = 1;
        int nAAA = 0;
        public DepthFirstSearch(Graph g)
        {
            //Lista para los nodos visitados
            List<NodeP> nVisited = new List<NodeP>();

            InitializeComponent();
            showDFS.AppendText("Nodos en el grafo:");
            foreach (var a in g)
            {
                showDFS.AppendText(a.Name + " ");
            }
            //Algoritmo para busqueda en profundidad
            DFS(g, nVisited);
            /*
            showDFS.AppendText("\nVer su numero de arbol:\n");
            foreach (var a in g)
            {
                showDFS.AppendText(a.Name + " Arbol: " +  a.numero_arbol + " Depth: " + a.Depth + "\n");
            }*/
        }


        private void DFS(Graph g, List<NodeP> nVisited)
        {
            //LISTA PARA ARISTAS DE ARBOL
            List<Edge> arblEdges = new List<Edge>();

            //LISTA PARA ARISTAS DE AVANCE
            List<Edge> advEdges = new List<Edge>();

            //LISTA PARA ARISTAS DE RETROCESO
            List<Edge> retEdges = new List<Edge>();

            //LISTA PARA ARISTAS CRUZADAS
            List<Edge> crzEdges = new List<Edge>();

            //LISTA PARA NODOS RAIZ
            List<NodeP> nRoot = new List<NodeP>();

            int count = 0; //Auxiliar contador
            bool isRoot; //Auxiliar para imprimir en distintos renglones los recorridos por raiz
            foreach (NodeP nodo in g)
            {
                //Cada que "Comienza" un recorrido, suponemos es el nodo con menos profundidad
                depth = 0;
                //noArb = 1;
                //Buscamos el nodo en la lista de visitados, de no estar  entramos en profundidad
                if (findNode(nodo, nVisited) == false)
                {
                    DFS_Recursive(nodo, nVisited, advEdges, arblEdges, retEdges, crzEdges, count, g, depth, nRoot, noArb);
                }
                //Si ya esta, simplemente pasamos al siguiente nodo, igual que si no hubiera estado. 
                count++;
            }
            // Caso base de la recursividad
            if (count == g.Count) 
            {
                //Mostramos la profundidad
                foreach (NodeP a in nVisited)
                {
                    isRoot = false;
                    foreach(NodeP b in nRoot)
                    {
                        //Si es son iguales, el nodo es raiz
                        if(b.Name == a.Name)
                        {
                            showDFS.AppendText("\n Raiz: (" + b.Name + ")  ");
                            isRoot = true;
                        }
                    }
                    if(isRoot == false)
                    {
                        showDFS.AppendText(a.Name + "  ");
                    }
                }
            }
            
            //Imprimiremos las aristas
            if(arblEdges.Count > 0)
            {
                showEdges.AppendText("\nAristas de Arbol:\n");
                foreach (var arbol in arblEdges)
                {
                    
                    showEdges.AppendText("Arbol " + arbol.arbolName + ": (" + arbol.Source.Name + "," + arbol.Destiny.Name + ")\n");
                }
            }
            if (advEdges.Count > 0)
            {
                showEdges.AppendText("\nAristas de Avance:\n");
                foreach (var avance in advEdges)
                {
                    showEdges.AppendText("Arbol " + avance.arbolName + ": (" + avance.Source.Name + "," + avance.Destiny.Name + ")\n");
                }
            }
            if (retEdges.Count > 0)
            {
                showEdges.AppendText("\nAristas de Retroceso:\n");
                foreach (var retroceso in retEdges)
                {
                    showEdges.AppendText("Arbol " + retroceso.arbolName + ": (" + retroceso.Source.Name + "," + retroceso.Destiny.Name + ")\n");
                }
            }
            if (crzEdges.Count > 0)
            {
                showEdges.AppendText("\nAristas Cruzadas:\n");
                foreach (var cruzadas in crzEdges)
                {
                    showEdges.AppendText("Arbol " + cruzadas.arbolName + ": (" + cruzadas.Source.Name + "," + cruzadas.Destiny.Name + ")\n");
                }
            }
        }

        private void DFS_Recursive(NodeP np, List<NodeP> nVisited, List<Edge> advEdges, List<Edge> arblEdges, List<Edge> retEdges, List<Edge> crzEdges, int count, Graph g, int depth, List<NodeP> nRoot, int noArbol)
        {
            Edge aux;
            int index = -1;
            for (int i = 0; i < g.Count; i++)
            {
                if (g[i].Name == np.Name)
                {
                    np = g[i];
                    g[i].Visited = true;
                    g[i].Depth = depth;
                    if (depth == 0)
                    {
                        g[i].numero_arbol = noArb;
                        noArb++;
                    }
                    else
                    {
                        g[i].numero_arbol = noArbol;
                    }
                    //g[i].numero_arbol = noArbol;
                    index = i;
                }
            }
            count++;

            //Si no esta, agregamos a la lista de visitados
            nVisited.Add(g[index]);
            
            //Si la profundidd es cero, es raiz, agregamos
            if (depth == 0)
            {
                nRoot.Add(g[index]);
                nAAA++;
            }
            noArbol = nRoot.Count;
            /*if (depth > 0)
            {
                noArbol = nRoot.Count+1;
            }*/

            foreach (NodeR nr in np.relations)
            {
                if (nr.Up.Visited == false)
                {
                    arblEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name, nRoot[nAAA-1].Name)); //Aristas de Arbol
                    depth++;
                    //DFS_Recursive(nr.Up, nVisited, advEdges, arblEdges, retEdges, crzEdges, count, g, depth, nRoot, noArbol);
                    //Si estamos en el primer nivel (osea, no en la raiz), este será mi arbol del que descenderan, entonces para diferenciarlos de los otros 
                    //utilizo el incremento +1, y de esta manera diferenciare mis aristas cruzadas 
                    if(depth == 1)
                    {
                        DFS_Recursive(nr.Up, nVisited, advEdges, arblEdges, retEdges, crzEdges, count, g, depth, nRoot, noArbol);
                    }
                    else
                    {
                        DFS_Recursive(nr.Up, nVisited, advEdges, arblEdges, retEdges, crzEdges, count, g, depth, nRoot, noArbol); 
                    }
                }
                /*else if (nr.Up.Depth != np.Depth && nr.Up.numero_arbol != np.numero_arbol) // Aristas Cruzadas
                {
                    crzEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name));
                }*/
                else if (nr.Up.numero_arbol != np.numero_arbol || nr.Up.Depth == np.Depth )  //Aristas de Cruce
                {
                    crzEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name, nRoot[nAAA - 1].Name));
                }
                else if (nr.Up.Depth < np.Depth && nr.Up.numero_arbol == np.numero_arbol) // Aristas de Retroceso
                {
                    retEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name, nRoot[nAAA - 1].Name));
                }
                else if (nr.Up.Depth > np.Depth && nr.Up.numero_arbol == np.numero_arbol) //Aristas de Avance
                {
                    advEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name, nRoot[nAAA - 1].Name)); 
                }
                /*else
                {
                    crzEdges.Add(aux = new Edge(0, np, nr.Up, g[index].Name));
                }*/
            }
        }

        private bool findNode(NodeP np, List<NodeP> nVisited)
        {
            bool result = false;
            foreach (var existingNode in nVisited)
            {
                if (existingNode == np)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

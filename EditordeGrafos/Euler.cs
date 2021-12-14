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
    public partial class Euler : Form
    {
        public Euler(Graph g)
        {
            InitializeComponent();
            alghoritmEuler(g);
        }

        private void alghoritmEuler(Graph g)
        {
            // LISTA PARA ARISTAS DE AULER
            List<Edge> eu = new List<Edge>();

            // LISTA PARA NODOS DE EULER
            List<NodeP> nE = new List<NodeP>();

            NodeP d;
            string c;

            g.UnselectAllEdges();
            if (VerifyCircuitEuler(g))
            {
                EulerCircuit(eu, g.First(), g.First(), false, nE, g);
                c = PrintListNode(nE, "");
                showEuler.AppendText("Circuito Euleriano: \n" + c);
                /*if (c != null)
                {
                    showEuler.AppendText("El Grafo no contiene circuito ni camino");
                }
                else
                {
                    showEuler.AppendText("Circuito Euleriano: \n" + c);
                }*/
            }
            else
            {
                if (VerifyPathEuler(g))
                {
                    d = FindOddNode(g);
                    EulerPath(eu, d, nE, g);
                    c = PrintListNode(nE, "");
                    showEuler.AppendText("Camino Euleriano: \n" + c);
                }
                else
                {
                    showEuler.AppendText("El Grafo no contiene circuito ni camino");
                }
            }
        }

        private bool EulerCircuit(List<Edge> circuito, NodeP OG, NodeP w, bool foundOG, List<NodeP> nodosRecorridos, Graph g)
        {
            Edge road = new Edge();
            nodosRecorridos.Add(w);
            foreach (NodeR r in w.relations)
            {
                road = g.GetEdge(w, r.Up);
                if (!road.Visited)
                {
                    road.Visited = true;
                    circuito.Add(road);
                    foundOG = EulerCircuit(circuito, OG, r.Up, foundOG, nodosRecorridos, g);
                    if (circuito.Count != g.edgesList.Count)
                    {
                        circuito.Remove(road);
                        nodosRecorridos.RemoveAt(nodosRecorridos.Count - 1);
                        road.Visited = false;
                        foundOG = false;
                    }
                    else
                    {
                        if (!foundOG)
                        {
                            circuito.Remove(road);
                            nodosRecorridos.Remove(w);
                            road.Visited = false;
                        }
                        return foundOG;
                    }
                }
            }
            if (w == OG)
            {
                foundOG = true;
            }
            else
            {
                nodosRecorridos.Remove(w);
            }


            return foundOG;
        }

        private void EulerPath(List<Edge> circuito, NodeP w, List<NodeP> nodosRecorridos, Graph g)
        {
            Edge road = new Edge();
            nodosRecorridos.Add(w);
            foreach (NodeR r in w.relations)
            {
                road = g.GetEdge(w, r.Up);
                if (!road.Visited)
                {
                    road.Visited = true;
                    circuito.Add(road);
                    EulerPath(circuito, r.Up, nodosRecorridos, g);
                    if (circuito.Count != g.edgesList.Count)
                    {
                        circuito.Remove(road);
                        nodosRecorridos.RemoveAt(nodosRecorridos.Count - 1);
                        road.Visited = false;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private NodeP FindOddNode(Graph g)
        {
            NodeP Odd = new NodeP();

            foreach (NodeP p in g)
            {
                if (!g.EdgeIsDirected)
                {
                    if (p.Degree % 2 != 0)
                    {
                        Odd = p;
                        break;
                    }
                }
                else
                {
                    if ((p.DegreeEx - p.DegreeIn) % 2 != 0 && p.DegreeEx > p.DegreeIn)
                    {
                        Odd = p;
                        break;
                    }
                }
            }

            return Odd;
        }

        private bool VerifyCircuitEuler(Graph g)
        {
            bool circuitoE = true;

            foreach (NodeP p in g)
            {
                if (!g.EdgeIsDirected)
                {
                    if (p.Degree % 2 != 0)
                    {
                        circuitoE = false;
                        break;
                    }
                }
                else
                {
                    if ((p.DegreeEx - p.DegreeIn) % 2 != 0)
                    {
                        circuitoE = false;
                        break;
                    }
                }
            }

            return circuitoE;
        }

        private bool VerifyPathEuler(Graph g)
        {
            bool caminoE = true;
            int countOddNodes = 0;

            foreach (NodeP p in g)
            {
                if (!g.EdgeIsDirected)
                {
                    if (p.Degree % 2 != 0)
                    {
                        countOddNodes++;
                    }
                }
                else
                {
                    if ((p.DegreeEx - p.DegreeIn) % 2 != 0)
                    {
                        countOddNodes++;
                    }
                }
                caminoE = (countOddNodes == 2) ? true : false;
            }

            return caminoE;
        }

        private string PrintListNode(List<NodeP> nodes, string format)
        {
            string text = format + "V = { ";
            int firstcycle = 0;
            foreach (NodeP node in nodes)
            {
                firstcycle++;
                text += node.Name;
                if (nodes.Last() != node || firstcycle < nodes.Count)
                {
                    text += " , ";
                }
            }
            text += " }";

            return text;
        }
    }
}

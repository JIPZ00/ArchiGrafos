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
    public partial class Prim : Form
    {
        List<List<int>> caminos;
        public double pesoT = 0;
        public Prim(Graph graph)
        {
            InitializeComponent();
            richTextBox_Prim.Text = "Aristas del arbol abarcador de costo minimo: " + System.Environment.NewLine;
            double[,] C = CreaC(graph);
            double[,] p = algoritmo(C, graph);
            richTextBox_Prim.Text += System.Environment.NewLine + "Peso Total del arbol: " + pesoT;
        }

        public double[,] CreaC(Graph graph)
        {
            double[,] C = new double[graph.Count, graph.Count];
            foreach (Edge edge in graph.edgesList)
            {
                C[ConvierteLetra(edge.Source.Name), ConvierteLetra(edge.Destiny.Name)] = edge.Weight;
                if (!graph.EdgeIsDirected)
                {
                    C[ConvierteLetra(edge.Destiny.Name), ConvierteLetra(edge.Source.Name)] = edge.Weight;
                }
            }
            return C;
        }

        public double[,] algoritmo(double[,] C, Graph graph)
        {
            bool[] marcados = new bool[graph.Count];
            NodeP vertice = graph[0];
            caminos = new List<List<int>>();
            return Prim_Rec(graph, C, marcados, vertice, new double[graph.Count, graph.Count]);
        }

        private double[,] Prim_Rec(Graph graph, double[,] matriz, bool[] marcados, NodeP vertice, double[,] final)
        {
            marcados[graph.IndexOf(vertice)] = true;
            double aux = -1;
            List<int> lista = new List<int>();

            if (!TodosMarcados(marcados))
            {
                for (int i = 0; i < marcados.Length; i++)
                {
                    if (marcados[i])
                    {
                        for (int j = 0; j < matriz.GetLength(0); j++)
                        {
                            if (matriz[i, j] != 0)
                            {
                                if (!marcados[j])
                                {
                                    if (aux == -1)
                                    {
                                        aux = matriz[i, j];
                                    }
                                    else
                                    {
                                        aux = Convert.ToDouble(Math.Min(aux, matriz[i, j]));
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < marcados.Length; i++)
                {
                    if (marcados[i])
                    {
                        for (int j = 0; j < matriz.GetLength(0); j++)
                        {
                            if (matriz[i, j] == aux)
                            {
                                if (!marcados[j])
                                {
                                    pesoT += matriz[i, j];
                                    final[i, j] = aux;
                                    richTextBox_Prim.Text += "(" + graph[i].Name + "-" + graph[j].Name + "), ";
                                    return Prim_Rec(graph, matriz, marcados, graph[j], final);
                                }
                            }
                        }
                    }
                }
            }
            return final;
        }

        public bool TodosMarcados(bool[] vertice)
        {
            foreach (var b in vertice)
            {
                if (!b)
                {
                    return b;
                }
            }
            return true;
        }
        public int ConvierteLetra(string letra)
        {
            int Num = 0;
            if (letra == "A")
            {
                Num = 0;
            }
            else if (letra == "B")
            {
                Num = 1;
            }
            else if (letra == "C")
            {
                Num = 2;
            }
            else if (letra == "D")
            {
                Num = 3;
            }
            else if (letra == "E")
            {
                Num = 4;
            }
            else if (letra == "F")
            {
                Num = 5;
            }
            else if (letra == "G")
            {
                Num = 6;
            }
            else if (letra == "H")
            {
                Num = 7;
            }
            else if (letra == "I")
            {
                Num = 8;
            }
            else if (letra == "J")
            {
                Num = 9;
            }
            else if (letra == "K")
            {
                Num = 10;
            }
            else if (letra == "L")
            {
                Num = 11;
            }
            else if (letra == "M")
            {
                Num = 12;
            }
            else if (letra == "N")
            {
                Num = 13;
            }
            else if (letra == "O")
            {
                Num = 14;
            }
            else if (letra == "P")
            {
                Num = 15;
            }
            else if (letra == "Q")
            {
                Num = 16;
            }
            else if (letra == "R")
            {
                Num = 17;
            }
            else if (letra == "S")
            {
                Num = 18;
            }
            else if (letra == "T")
            {
                Num = 19;
            }
            else if (letra == "U")
            {
                Num = 20;
            }
            else if (letra == "V")
            {
                Num = 21;
            }
            else if (letra == "W")
            {
                Num = 22;
            }
            else if (letra == "X")
            {
                Num = 23;
            }
            else if (letra == "Y")
            {
                Num = 24;
            }
            else if (letra == "Z")
            {
                Num = 25;
            }
            return Num;

        }
    }
}

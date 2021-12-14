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
    public partial class MuestraGradosGrafo : Form
    {
        int gradoGrafo;
        public MuestraGradosGrafo(Graph graph, bool edgeIsDirected)
        {
            InitializeComponent();
            muestraGrafos(graph, edgeIsDirected);
        }

        private void muestraGrafos(Graph graph, bool edgeIsDirected)
        {
            bool oreja;
            if (edgeIsDirected == false)
            {
                //Por cada nodo en el grafo
                foreach (var a in graph)
                {
                    oreja = false;
                    richTextBox_MuestraGrafos.AppendText(a.Name + "\n");
                    //richTextBox_GradoNodos.AppendText(a.relations.Count + "\n");
                    if (a.relations.Count > 0)
                    {
                        gradoGrafo += a.relations.Count;
                    }
                    //Checa oreja:
                    //Por cada arista en la lista de aristas
                    foreach (var b in graph.edgesList)
                    {
                        if (b.Source.Name == b.Destiny.Name && b.Source.Name == a.Name)
                        {
                            gradoGrafo += 1;
                            oreja = true;
                            break;
                        }
                    }
                    if (oreja == false)
                    {
                        richTextBox_GradoNodos.AppendText(a.relations.Count + "\n");
                    }
                    else
                    {
                        richTextBox_GradoNodos.AppendText((a.relations.Count + 1) + "\n");
                    }
                }
            }
            else
            {
                foreach (var a in graph)
                {
                    richTextBox_MuestraGrafos.AppendText(a.Name + "\n");
                    richTextBox_GradoNExterno.AppendText(a.DegreeEx + "\n");
                    richTextBox_GradoNInterno.AppendText(a.DegreeIn + "\n");
                    gradoGrafo += a.DegreeEx;
                    if (a.Visited == true)
                    {
                        richTextBox_GradoNInterno.AppendText(a.DegreeIn + "\n");
                    }
                }
            }
            richTextBox_GradoGrafo.AppendText("El grado total del grafo es: " + gradoGrafo);
        }
    }
}

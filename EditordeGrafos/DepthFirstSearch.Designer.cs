
namespace EditordeGrafos
{
    partial class DepthFirstSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepthFirstSearch));
            this.label_show_Recorrido = new System.Windows.Forms.Label();
            this.showDFS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showEdges = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_show_Recorrido
            // 
            this.label_show_Recorrido.AutoSize = true;
            this.label_show_Recorrido.Location = new System.Drawing.Point(43, 9);
            this.label_show_Recorrido.Name = "label_show_Recorrido";
            this.label_show_Recorrido.Size = new System.Drawing.Size(80, 13);
            this.label_show_Recorrido.TabIndex = 2;
            this.label_show_Recorrido.Text = "Recorrido DFS:";
            // 
            // showDFS
            // 
            this.showDFS.Enabled = false;
            this.showDFS.Location = new System.Drawing.Point(12, 34);
            this.showDFS.Name = "showDFS";
            this.showDFS.Size = new System.Drawing.Size(264, 298);
            this.showDFS.TabIndex = 4;
            this.showDFS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipos de Aristas:";
            // 
            // showEdges
            // 
            this.showEdges.Enabled = false;
            this.showEdges.Location = new System.Drawing.Point(293, 34);
            this.showEdges.Name = "showEdges";
            this.showEdges.Size = new System.Drawing.Size(264, 298);
            this.showEdges.TabIndex = 6;
            this.showEdges.Text = "";
            // 
            // DepthFirstSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 344);
            this.Controls.Add(this.showEdges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDFS);
            this.Controls.Add(this.label_show_Recorrido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepthFirstSearch";
            this.Text = "Bosque Abarcador en Profundidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_show_Recorrido;
        private System.Windows.Forms.RichTextBox showDFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox showEdges;
    }
}
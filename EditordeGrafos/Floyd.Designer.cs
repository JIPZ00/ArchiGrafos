
namespace EditordeGrafos
{
    partial class Floyd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Floyd));
            this.NodosRecorridosBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DijkstraIniciate = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costoInicial_Floyd = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costoMinimo_Floyd = new System.Windows.Forms.RichTextBox();
            this.recorridos_Floyd = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NodosRecorridosBox
            // 
            this.NodosRecorridosBox.Location = new System.Drawing.Point(388, 275);
            this.NodosRecorridosBox.Name = "NodosRecorridosBox";
            this.NodosRecorridosBox.Size = new System.Drawing.Size(330, 20);
            this.NodosRecorridosBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Recorrido de Nodos:";
            // 
            // DijkstraIniciate
            // 
            this.DijkstraIniciate.Location = new System.Drawing.Point(272, 256);
            this.DijkstraIniciate.Name = "DijkstraIniciate";
            this.DijkstraIniciate.Size = new System.Drawing.Size(98, 48);
            this.DijkstraIniciate.TabIndex = 15;
            this.DijkstraIniciate.Text = "Obten Recorrido";
            this.DijkstraIniciate.UseVisualStyleBackColor = true;
            this.DijkstraIniciate.Click += new System.EventHandler(this.DijkstraIniciate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 283);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vertice Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vertice Inicial";
            // 
            // costoInicial_Floyd
            // 
            this.costoInicial_Floyd.Enabled = false;
            this.costoInicial_Floyd.Location = new System.Drawing.Point(40, 33);
            this.costoInicial_Floyd.Name = "costoInicial_Floyd";
            this.costoInicial_Floyd.Size = new System.Drawing.Size(330, 202);
            this.costoInicial_Floyd.TabIndex = 22;
            this.costoInicial_Floyd.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Matriz de Costos Minimo.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Matriz de Costos Inicial.";
            // 
            // costoMinimo_Floyd
            // 
            this.costoMinimo_Floyd.Enabled = false;
            this.costoMinimo_Floyd.Location = new System.Drawing.Point(388, 31);
            this.costoMinimo_Floyd.Name = "costoMinimo_Floyd";
            this.costoMinimo_Floyd.Size = new System.Drawing.Size(330, 202);
            this.costoMinimo_Floyd.TabIndex = 26;
            this.costoMinimo_Floyd.Text = "";
            // 
            // recorridos_Floyd
            // 
            this.recorridos_Floyd.Enabled = false;
            this.recorridos_Floyd.Location = new System.Drawing.Point(1040, 27);
            this.recorridos_Floyd.Name = "recorridos_Floyd";
            this.recorridos_Floyd.Size = new System.Drawing.Size(330, 202);
            this.recorridos_Floyd.TabIndex = 28;
            this.recorridos_Floyd.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1037, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Matriz de Recorridos.";
            // 
            // Floyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 345);
            this.Controls.Add(this.recorridos_Floyd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.costoMinimo_Floyd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.costoInicial_Floyd);
            this.Controls.Add(this.NodosRecorridosBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DijkstraIniciate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Floyd";
            this.Text = "Floyd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NodosRecorridosBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DijkstraIniciate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox costoInicial_Floyd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox costoMinimo_Floyd;
        private System.Windows.Forms.RichTextBox recorridos_Floyd;
        private System.Windows.Forms.Label label8;
    }
}
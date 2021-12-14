
namespace EditordeGrafos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Botton1 = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apt5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.boxElimina = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFD
            // 
            this.saveFD.DefaultExt = "dd";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // Botton1
            // 
            this.Botton1.Location = new System.Drawing.Point(148, 24);
            this.Botton1.Name = "Botton1";
            this.Botton1.Size = new System.Drawing.Size(75, 23);
            this.Botton1.TabIndex = 14;
            this.Botton1.Text = "Insertar";
            this.Botton1.UseVisualStyleBackColor = true;
            this.Botton1.Click += new System.EventHandler(this.AddBoton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(9, 27);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(121, 20);
            this.TextBox.TabIndex = 12;
            this.TextBox.Text = "DATO";
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Direccion,
            this.Tipo,
            this.Apt1,
            this.Dato1,
            this.Apt2,
            this.Dato2,
            this.Apt3,
            this.Dato3,
            this.Apt4,
            this.Dato4,
            this.Apt5});
            this.DataGridView1.Location = new System.Drawing.Point(9, 70);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(1144, 467);
            this.DataGridView1.TabIndex = 18;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dir";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Apt1
            // 
            this.Apt1.HeaderText = "AP";
            this.Apt1.Name = "Apt1";
            this.Apt1.ReadOnly = true;
            // 
            // Dato1
            // 
            this.Dato1.HeaderText = "CB";
            this.Dato1.Name = "Dato1";
            this.Dato1.ReadOnly = true;
            // 
            // Apt2
            // 
            this.Apt2.HeaderText = "AP";
            this.Apt2.Name = "Apt2";
            this.Apt2.ReadOnly = true;
            // 
            // Dato2
            // 
            this.Dato2.HeaderText = "CB";
            this.Dato2.Name = "Dato2";
            this.Dato2.ReadOnly = true;
            // 
            // Apt3
            // 
            this.Apt3.HeaderText = "AP";
            this.Apt3.Name = "Apt3";
            this.Apt3.ReadOnly = true;
            // 
            // Dato3
            // 
            this.Dato3.HeaderText = "CB";
            this.Dato3.Name = "Dato3";
            this.Dato3.ReadOnly = true;
            // 
            // Apt4
            // 
            this.Apt4.HeaderText = "AP";
            this.Apt4.Name = "Apt4";
            this.Apt4.ReadOnly = true;
            // 
            // Dato4
            // 
            this.Dato4.HeaderText = "CB";
            this.Dato4.Name = "Dato4";
            this.Dato4.ReadOnly = true;
            // 
            // Apt5
            // 
            this.Apt5.HeaderText = "AP";
            this.Apt5.Name = "Apt5";
            this.Apt5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(615, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "TAMAÑO DE REGISTROS:  30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "TAMAÑO DE DATOS:  25";
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(389, 24);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 22;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // boxElimina
            // 
            this.boxElimina.Location = new System.Drawing.Point(250, 27);
            this.boxElimina.Name = "boxElimina";
            this.boxElimina.Size = new System.Drawing.Size(121, 20);
            this.boxElimina.TabIndex = 21;
            this.boxElimina.Text = "DATO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 549);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.boxElimina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Botton1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Button Botton1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox boxElimina;
    }
}
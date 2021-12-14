
namespace EditordeGrafos
{
    partial class hashTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hashTable));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.claveUD = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DatosInsertados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaEOF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.entradaRanuras = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaRegistros = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaTamReg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.claveUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaRanuras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaTamReg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(93, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Elimina Dato";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(12, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Inserta Dato";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // claveUD
            // 
            this.claveUD.Enabled = false;
            this.claveUD.Location = new System.Drawing.Point(12, 27);
            this.claveUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.claveUD.Name = "claveUD";
            this.claveUD.Size = new System.Drawing.Size(156, 20);
            this.claveUD.TabIndex = 9;
            this.claveUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 8;
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
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosInsertados});
            this.DataGridView1.Location = new System.Drawing.Point(12, 82);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(182, 323);
            this.DataGridView1.TabIndex = 15;
            // 
            // DatosInsertados
            // 
            this.DatosInsertados.HeaderText = "DATOS";
            this.DatosInsertados.Name = "DatosInsertados";
            // 
            // entradaEOF
            // 
            this.entradaEOF.Location = new System.Drawing.Point(219, 101);
            this.entradaEOF.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.entradaEOF.Name = "entradaEOF";
            this.entradaEOF.Size = new System.Drawing.Size(103, 20);
            this.entradaEOF.TabIndex = 17;
            this.entradaEOF.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Inicio EOF";
            // 
            // entradaRanuras
            // 
            this.entradaRanuras.Location = new System.Drawing.Point(219, 164);
            this.entradaRanuras.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.entradaRanuras.Name = "entradaRanuras";
            this.entradaRanuras.Size = new System.Drawing.Size(103, 20);
            this.entradaRanuras.TabIndex = 19;
            this.entradaRanuras.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de ranuras:";
            // 
            // entradaRegistros
            // 
            this.entradaRegistros.Location = new System.Drawing.Point(219, 226);
            this.entradaRegistros.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.entradaRegistros.Name = "entradaRegistros";
            this.entradaRegistros.Size = new System.Drawing.Size(103, 20);
            this.entradaRegistros.TabIndex = 21;
            this.entradaRegistros.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Registros";
            // 
            // entradaTamReg
            // 
            this.entradaTamReg.Location = new System.Drawing.Point(219, 291);
            this.entradaTamReg.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.entradaTamReg.Name = "entradaTamReg";
            this.entradaTamReg.Size = new System.Drawing.Size(103, 20);
            this.entradaTamReg.TabIndex = 23;
            this.entradaTamReg.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tamaño de registros";
            // 
            // hashTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 417);
            this.Controls.Add(this.entradaTamReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entradaRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaRanuras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entradaEOF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.claveUD);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hashTable";
            this.Text = "Tabla Hash Estatica";
            ((System.ComponentModel.ISupportInitialize)(this.claveUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaEOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaRanuras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaTamReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown claveUD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosInsertados;
        private System.Windows.Forms.NumericUpDown entradaEOF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown entradaRanuras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown entradaRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown entradaTamReg;
        private System.Windows.Forms.Label label3;
    }
}
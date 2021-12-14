
namespace EditordeGrafos
{
    partial class Euler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Euler));
            this.showEuler = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // showEuler
            // 
            this.showEuler.Location = new System.Drawing.Point(12, 26);
            this.showEuler.Name = "showEuler";
            this.showEuler.Size = new System.Drawing.Size(216, 176);
            this.showEuler.TabIndex = 0;
            this.showEuler.Text = "";
            // 
            // Euler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 214);
            this.Controls.Add(this.showEuler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Euler";
            this.Text = "Euler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox showEuler;
    }
}
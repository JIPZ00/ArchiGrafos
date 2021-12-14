
namespace EditordeGrafos
{
    partial class Prim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prim));
            this.richTextBox_Prim = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Prim
            // 
            this.richTextBox_Prim.Enabled = false;
            this.richTextBox_Prim.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Prim.Name = "richTextBox_Prim";
            this.richTextBox_Prim.Size = new System.Drawing.Size(588, 91);
            this.richTextBox_Prim.TabIndex = 0;
            this.richTextBox_Prim.Text = "";
            // 
            // Prim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 114);
            this.Controls.Add(this.richTextBox_Prim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prim";
            this.Text = "Prim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Prim;
    }
}
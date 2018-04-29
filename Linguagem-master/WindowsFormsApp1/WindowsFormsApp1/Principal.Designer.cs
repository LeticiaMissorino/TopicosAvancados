namespace WindowsFormsApp1
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linguagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linguagemToolStripMenuItem,
            this.repositorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linguagemToolStripMenuItem
            // 
            this.linguagemToolStripMenuItem.Name = "linguagemToolStripMenuItem";
            this.linguagemToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.linguagemToolStripMenuItem.Text = "Linguagem";
            this.linguagemToolStripMenuItem.Click += new System.EventHandler(this.linguagemToolStripMenuItem_Click);
            // 
            // repositorioToolStripMenuItem
            // 
            this.repositorioToolStripMenuItem.Name = "repositorioToolStripMenuItem";
            this.repositorioToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.repositorioToolStripMenuItem.Text = "Repositorio";
            this.repositorioToolStripMenuItem.Click += new System.EventHandler(this.repositorioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linguagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositorioToolStripMenuItem;
    }
}
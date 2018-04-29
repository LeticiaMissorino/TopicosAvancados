namespace ControleProblemasView
{
    partial class FrmPrincipal
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
            this.menuCadastroTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroNivel = new System.Windows.Forms.ToolStripMenuItem();
            this.problemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProblema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroTipo,
            this.nivelToolStripMenuItem,
            this.problemaToolStripMenuItem,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastroTipo
            // 
            this.menuCadastroTipo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuCadastroTipo.Name = "menuCadastroTipo";
            this.menuCadastroTipo.Size = new System.Drawing.Size(43, 20);
            this.menuCadastroTipo.Text = "Tipo";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroNivel});
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.nivelToolStripMenuItem.Text = "Nivel";
            // 
            // menuCadastroNivel
            // 
            this.menuCadastroNivel.Name = "menuCadastroNivel";
            this.menuCadastroNivel.Size = new System.Drawing.Size(121, 22);
            this.menuCadastroNivel.Text = "Cadastro";
            this.menuCadastroNivel.Click += new System.EventHandler(this.menuCadastroNivel_Click);
            // 
            // problemaToolStripMenuItem
            // 
            this.problemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProblema});
            this.problemaToolStripMenuItem.Name = "problemaToolStripMenuItem";
            this.problemaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.problemaToolStripMenuItem.Text = "Problema";
            // 
            // menuCadastroProblema
            // 
            this.menuCadastroProblema.Name = "menuCadastroProblema";
            this.menuCadastroProblema.Size = new System.Drawing.Size(121, 22);
            this.menuCadastroProblema.Text = "Cadastro";
            this.menuCadastroProblema.Click += new System.EventHandler(this.menuCadastroProblema_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroTipo;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroNivel;
        private System.Windows.Forms.ToolStripMenuItem problemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProblema;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}
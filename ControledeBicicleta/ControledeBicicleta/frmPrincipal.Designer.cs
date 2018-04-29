namespace ControledeBicicleta
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroBicicleta = new System.Windows.Forms.ToolStripMenuItem();
            this.sRAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargoToolStripMenuItem,
            this.fabricanteToolStripMenuItem,
            this.cargoToolStripMenuItem1,
            this.sRAIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroCargo});
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cargoToolStripMenuItem.Text = "Cargo";
            // 
            // menuCadastroCargo
            // 
            this.menuCadastroCargo.Name = "menuCadastroCargo";
            this.menuCadastroCargo.Size = new System.Drawing.Size(121, 22);
            this.menuCadastroCargo.Text = "Cadastro";
            this.menuCadastroCargo.Click += new System.EventHandler(this.menuCadastroCargo_Click);
            // 
            // fabricanteToolStripMenuItem
            // 
            this.fabricanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFabricante});
            this.fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            this.fabricanteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fabricanteToolStripMenuItem.Text = "Fabricante";
            // 
            // menuCadastroFabricante
            // 
            this.menuCadastroFabricante.Name = "menuCadastroFabricante";
            this.menuCadastroFabricante.Size = new System.Drawing.Size(121, 22);
            this.menuCadastroFabricante.Text = "Cadastro";
            this.menuCadastroFabricante.Click += new System.EventHandler(this.menuCadastroFabricante_Click);
            // 
            // cargoToolStripMenuItem1
            // 
            this.cargoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroBicicleta});
            this.cargoToolStripMenuItem1.Name = "cargoToolStripMenuItem1";
            this.cargoToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.cargoToolStripMenuItem1.Text = "Bicicleta";
            // 
            // menuCadastroBicicleta
            // 
            this.menuCadastroBicicleta.Name = "menuCadastroBicicleta";
            this.menuCadastroBicicleta.Size = new System.Drawing.Size(121, 22);
            this.menuCadastroBicicleta.Text = "Cadastro";
            this.menuCadastroBicicleta.Click += new System.EventHandler(this.menuCadastroBicicleta_Click);
            // 
            // sRAIToolStripMenuItem
            // 
            this.sRAIToolStripMenuItem.Name = "sRAIToolStripMenuItem";
            this.sRAIToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sRAIToolStripMenuItem.Text = "Sair";
            this.sRAIToolStripMenuItem.Click += new System.EventHandler(this.sRAIToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCargo;
        private System.Windows.Forms.ToolStripMenuItem fabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFabricante;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroBicicleta;
        private System.Windows.Forms.ToolStripMenuItem sRAIToolStripMenuItem;
    }
}


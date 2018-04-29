namespace WindowsFormsApp1
{
    partial class FRMRepositorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtxData = new System.Windows.Forms.TextBox();
            this.cboLing = new System.Windows.Forms.ComboBox();
            this.dgResp = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgResp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Linguagem:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(378, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtxData
            // 
            this.txtxData.Location = new System.Drawing.Point(59, 146);
            this.txtxData.Name = "txtxData";
            this.txtxData.Size = new System.Drawing.Size(100, 20);
            this.txtxData.TabIndex = 4;
            // 
            // cboLing
            // 
            this.cboLing.FormattingEnabled = true;
            this.cboLing.Location = new System.Drawing.Point(59, 225);
            this.cboLing.Name = "cboLing";
            this.cboLing.Size = new System.Drawing.Size(207, 21);
            this.cboLing.TabIndex = 5;
            // 
            // dgResp
            // 
            this.dgResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResp.Location = new System.Drawing.Point(59, 288);
            this.dgResp.Name = "dgResp";
            this.dgResp.Size = new System.Drawing.Size(504, 150);
            this.dgResp.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(389, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Repositorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgResp);
            this.Controls.Add(this.cboLing);
            this.Controls.Add(this.txtxData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Repositorio";
            this.Text = "Repositorio";
            this.Load += new System.EventHandler(this.Repositorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtxData;
        private System.Windows.Forms.ComboBox cboLing;
        private System.Windows.Forms.DataGridView dgResp;
        private System.Windows.Forms.Button btnSalvar;
    }
}
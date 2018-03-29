namespace LabirintoRecursivo
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirLabirintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criadoresDoTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richtxtLabirinto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.criadoresDoTrabalhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirLabirintoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirLabirintoToolStripMenuItem
            // 
            this.abrirLabirintoToolStripMenuItem.Name = "abrirLabirintoToolStripMenuItem";
            this.abrirLabirintoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirLabirintoToolStripMenuItem.Text = "Abrir Labirinto";
            this.abrirLabirintoToolStripMenuItem.Click += new System.EventHandler(this.abrirLabirintoToolStripMenuItem_Click);
            // 
            // criadoresDoTrabalhoToolStripMenuItem
            // 
            this.criadoresDoTrabalhoToolStripMenuItem.Name = "criadoresDoTrabalhoToolStripMenuItem";
            this.criadoresDoTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.criadoresDoTrabalhoToolStripMenuItem.Text = "Criadores do Trabalho";
            this.criadoresDoTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.criadoresDoTrabalhoToolStripMenuItem_Click);
            // 
            // richtxtLabirinto
            // 
            this.richtxtLabirinto.BackColor = System.Drawing.Color.White;
            this.richtxtLabirinto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxtLabirinto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtLabirinto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richtxtLabirinto.Location = new System.Drawing.Point(0, 24);
            this.richtxtLabirinto.Name = "richtxtLabirinto";
            this.richtxtLabirinto.Size = new System.Drawing.Size(716, 349);
            this.richtxtLabirinto.TabIndex = 1;
            this.richtxtLabirinto.Text = "";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 373);
            this.Controls.Add(this.richtxtLabirinto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Labirinto Recursivo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirLabirintoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richtxtLabirinto;
        private System.Windows.Forms.ToolStripMenuItem criadoresDoTrabalhoToolStripMenuItem;
    }
}


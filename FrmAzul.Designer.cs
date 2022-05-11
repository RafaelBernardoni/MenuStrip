namespace AppExemploMenu
{
    partial class FrmAzul
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
            this.Azul = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirRosa = new System.Windows.Forms.ToolStripMenuItem();
            this.Azul.SuspendLayout();
            this.SuspendLayout();
            // 
            // Azul
            // 
            this.Azul.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.Azul.Location = new System.Drawing.Point(0, 0);
            this.Azul.Name = "Azul";
            this.Azul.Size = new System.Drawing.Size(800, 24);
            this.Azul.TabIndex = 0;
            this.Azul.Text = "menuStrip1";
            this.Azul.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.exibirAzul_ItemClicked);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAzul,
            this.exibirVermelho,
            this.exibirRosa});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // exibirAzul
            // 
            this.exibirAzul.Name = "exibirAzul";
            this.exibirAzul.Size = new System.Drawing.Size(180, 22);
            this.exibirAzul.Text = "FormAzul";
            this.exibirAzul.Click += new System.EventHandler(this.exibirAzul_Click);
            // 
            // exibirVermelho
            // 
            this.exibirVermelho.Name = "exibirVermelho";
            this.exibirVermelho.Size = new System.Drawing.Size(180, 22);
            this.exibirVermelho.Text = "FrmVermelho";
            this.exibirVermelho.Click += new System.EventHandler(this.exibirVermelho_Click);
            // 
            // exibirRosa
            // 
            this.exibirRosa.Name = "exibirRosa";
            this.exibirRosa.Size = new System.Drawing.Size(180, 22);
            this.exibirRosa.Text = "FrmRosa";
            this.exibirRosa.Click += new System.EventHandler(this.exibirRosa_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Azul);
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAzul";
            this.Load += new System.EventHandler(this.FrmAzul_Load);
            this.Azul.ResumeLayout(false);
            this.Azul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Azul;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirRosa;
    }
}


namespace AppExemploMenu
{
    partial class FrmRosa
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
            this.Rosa = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirRosa = new System.Windows.Forms.ToolStripMenuItem();
            this.Rosa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rosa
            // 
            this.Rosa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.Rosa.Location = new System.Drawing.Point(0, 0);
            this.Rosa.Name = "Rosa";
            this.Rosa.Size = new System.Drawing.Size(800, 24);
            this.Rosa.TabIndex = 1;
            this.Rosa.Text = "menuStrip1";
            this.Rosa.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.exibirRosa_ItemClicked);
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
            this.exibirRosa.Click += new System.EventHandler(this.frmRosaToolStripMenuItem_Click);
            // 
            // FrmRosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rosa);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmRosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRosa";
            this.Rosa.ResumeLayout(false);
            this.Rosa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Rosa;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirVermelho;
        private System.Windows.Forms.ToolStripMenuItem exibirRosa;
    }
}
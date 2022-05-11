using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmRosa : Form
    {
        public FrmRosa()
        {
            InitializeComponent();
        }

        private void exibirRosa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmRosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRosa frm = new FrmRosa();
            this.Hide();//fechar atual
            frm.ShowDialog();
        }

        private void exibirAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul();
            this.Hide();//fechar atual
            frm.ShowDialog();
        }

        private void exibirVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();
            this.Hide();//fechar atual
            frm.ShowDialog();
        }
    }
}

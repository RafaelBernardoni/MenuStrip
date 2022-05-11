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
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void FrmAzul_Load(object sender, EventArgs e)
        {

        }

        private void exibirAzul_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void exibirAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul();//indico qual form sera aberto
            this.Hide();//fechar atual
            frm.ShowDialog();
        }

        private void exibirVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho();
            this.Hide();//fechar atual
            frm.ShowDialog();
        }

        private void exibirRosa_Click(object sender, EventArgs e)
        {
            FrmRosa frm = new FrmRosa();//indico qual form sera aberto
            this.Hide();//fechar atual
            frm.ShowDialog();
        }
    }
}

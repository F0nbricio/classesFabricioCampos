using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduçãoClasses
{
    public partial class FrmLoja : Form
    {
        public FrmLoja()
        {
            InitializeComponent();
        }

        private void prefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito();//Indico qual forms sera aberto
            this.Hide();//fecho o atual
            frm.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja();//Indico qual forms sera aberto
            this.Hide();//fecho o atual
            frm.ShowDialog();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento();//Indico qual forms sera aberto
            this.Hide();//fecho o atual
            frm.ShowDialog();
        }
    }
}

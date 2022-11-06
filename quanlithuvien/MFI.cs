using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlithuvien
{
    public partial class MFI : Form
    {
        public MFI()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tv = new qltv();
            tv.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dg = new qldocgia();
            dg.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nv = new qlnv();
            nv.Show();
        }

        private void tìmKiếmSáchVàĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tk = new tksach();
            tk.Show();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

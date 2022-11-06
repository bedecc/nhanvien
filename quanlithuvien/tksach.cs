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
    public partial class tksach : Form
    {
        public tksach()
        {
            InitializeComponent();
        }

        private void bt_masach_Click(object sender, EventArgs e)
        {

            string sql = "Select * from sach where masach like '%" +cbb_masach.SelectedIndex.ToString() + "%'";
            DataTable dt = ketnoi.truyvan(sql);
            dataGridView1.DataSource = dt;
        }

        private void cbb_masach_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.bt_tacgia.Enabled = false;

        }

        private void tksach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet1.sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter1.Fill(this.qLTVDataSet1.sach);
            // TODO: This line of code loads data into the 'qLTVDataSet.sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qLTVDataSet.sach);

         

        }

        private void bt_tacgia_Click(object sender, EventArgs e)
        {
            
                string sqltg = "Select * from sach where tacgia like'%" + textBox1.Text + "%' ";
                DataTable dt = ketnoi.truyvan(sqltg);
                dataGridView1.DataSource = dt;
           
                
           

        }

        private void cbb_tacgia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sachTableAdapter.FillBy(this.qLTVDataSet.sach);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cbb_masach.Enabled = false;
            this.bt_masach.Enabled = false;
        }
    }
}

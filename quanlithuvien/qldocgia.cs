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
    public partial class qldocgia : Form
    {
        public qldocgia()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void qldocgia_Load(object sender, EventArgs e)
        {
            string selectall = "select * from docgia";
            DataTable dt = ketnoi.truyvan(selectall);
            dataGridView1.DataSource = dt;
            this.groupBox1.Enabled = false;
            this.bt_them.Enabled = false;
            this.bt_huy.Enabled = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string madg = txt_madg.Text.Trim();
            string hoten = txt_hoten.Text.Trim();
            int sdt = int.Parse(txt_sdt.Text.Trim());
            string diachi = txt_diachi.Text.Trim();
            try
            { 
             if (txt_madg.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã độc giả", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_madg.Focus();
            }
            else if (txt_hoten.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tác giả", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_hoten.Focus();
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("bạn chưa nhập nhà xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_sdt.Focus();
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập năm xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txt_diachi.Focus();
            }

            else
            {
                    string sl_them = "INSERT INTO docgia (madocgia,hotendocgia,diachi,sodienthoai) VALUES('" + madg + "','" + hoten + "','" + sdt + "','" + diachi + "')";
                ketnoi.thucthi(sl_them);
                string selecttv = "select * from docgia";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("bạn đã thêm thành công", "thông báo", MessageBoxButtons.OK);
            }
        }
            catch(Exception )
            {
                MessageBox.Show("bạn đã thêm mã sách rồi ","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
}

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string madg = txt_madg.Text.Trim();
                string hoten = txt_hoten.Text.Trim();
                int sdt = int.Parse(txt_sdt.Text.Trim());
                string diachi = txt_diachi.Text.Trim();
                string updatesach = "update docgia set hotendocgia = '" + hoten+ "',sodienthoai = '" + sdt+ "',diachi ='" + diachi +"'where docgia.madocgia = '"+madg+  "'";
                ketnoi.thucthi(updatesach);
                string selecttv = "select * from docgia";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("đã sửa lại thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi", "cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txt_madg.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txt_hoten.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            this.bt_them.Enabled = false;
            this.bt_sua.Enabled = true;
            this.bt_xoa.Enabled = true;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string xoama = txt_madg.Text.Trim();
            DialogResult dlr = MessageBox.Show("bạn có chắc muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                string selectsach = "select madocgia from docgia where madocgia ='" + xoama + "'";
                DataTable rm = ketnoi.truyvan(selectsach);
                string masach = rm.Rows[0][0].ToString();
                string dellma = "delete from docgia where madocgia = '" + txt_madg.Text + "'";
                ketnoi.thucthi(dellma);
                string selecttv = "select * from docgia";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("đã xóa thành công", "thông báo", MessageBoxButtons.OK);
            }
        }

        private void bt_luu_Click_1(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.bt_them.Enabled = true;
            this.bt_huy.Enabled = true;
            this.bt_sua.Enabled = false;
            this.bt_xoa.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            txt_madg.ResetText();
            txt_hoten.ResetText();
            txt_sdt.ResetText();
            txt_diachi.ResetText();
          
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("bạn có muốn thoát chứ", "thông bấo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

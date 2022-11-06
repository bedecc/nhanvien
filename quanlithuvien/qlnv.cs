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
    public partial class qlnv : Form
    {
        public qlnv()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qlnv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet5.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.qLTVDataSet5.nhanvien);
            string selectall = "select * from nhanvien";
            DataTable dt = ketnoi.truyvan(selectall);
            dataGridView1.DataSource = dt;
            this.groupBox1.Enabled = false;
            this.bt_them.Enabled = false;
            this.bt_huy.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.bt_them.Enabled = true;
            this.bt_huy.Enabled = true;
            this.bt_sua.Enabled = false;
            this.bt_xoa.Enabled = false;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {

                string manv = txt_manv.Text.Trim();
                string ten = txt_tennv.Text.Trim();
                string sdt = txt_sdt.Text.Trim();
                string gioitinh = cbb_gioitinh.Text.Trim();
                string diachi = txt_diachi.Text.Trim();
                if (txt_manv.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập mã", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_manv.Focus();
                }
            else if (txt_tennv.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_tennv.Focus();
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tác giả", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_sdt.Focus();
            }
            else if (cbb_gioitinh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập nhà xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbb_gioitinh.Focus();
            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập năm xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              txt_diachi.Focus();
            }

            else
            {
                string sl_them = "INSERT INTO nhanvien  (manv,tennv,sdt,gioitinh,diachi) VALUES('" + manv + "','" + ten + "','" + sdt + "','" + gioitinh + "','" + diachi + "')";
                ketnoi.thucthi(sl_them);
                string selecttv = "select * from nhanvien";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("bạn đã thêm thành công", "thông báo", MessageBoxButtons.OK);
            }
        }
            catch(Exception )
            {
                MessageBox.Show("lỗi ","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

}

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txt_manv.Text.Trim();
                string ten = txt_tennv.Text.Trim();
                string sdt = txt_sdt.Text.Trim();
                string gioitinh = cbb_gioitinh.Text.Trim();
                string diachi = txt_diachi.Text.Trim();
                string update = "update nhanvien set tennv = '" + ten + "',gioitinh = '" + gioitinh + "',sdt ='" + sdt +"',diachi = '"+diachi+ "'where nhanvien.manv = '" + manv + "'";
                ketnoi.thucthi(update);
                string selecttv = "select * from nhanvien";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("đã sửa lại thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi", "cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txt_manv.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txt_sdt.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            cbb_gioitinh.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            this.bt_them.Enabled = false;
            this.bt_sua.Enabled = true;
            this.bt_xoa.Enabled = true;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string xoama = txt_manv.Text.Trim();
            DialogResult dlr = MessageBox.Show("bạn có chắc muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                string selectsach = "select manv from nhanvien where manv ='" + xoama + "'";
                DataTable rm = ketnoi.truyvan(selectsach);
                string masach = rm.Rows[0][0].ToString();
                string dellma = "delete from nhanvien where manv = '" + txt_manv.Text + "'";
                ketnoi.thucthi(dellma);
                string selecttv = "select * from nhanvien";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            txt_manv.ResetText();
            txt_tennv.ResetText();
            txt_sdt.ResetText();
            txt_diachi.ResetText();
            cbb_gioitinh.ResetText();
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

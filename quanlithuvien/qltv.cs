using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlithuvien
{
    public partial class qltv : Form
    {
        public qltv()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qltv_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.bt_them.Enabled = false;
            this.bt_huy.Enabled = false;
            string selecttv = "select * from sach";
            DataTable dt = ketnoi.truyvan(selecttv);
            dataGridView1.DataSource = dt;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        

        

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                
                string masach = txt_masach.Text.Trim();
                string tensach = txt_tensach.Text.Trim();
                string tacgia = txt_tacgia.Text.Trim();
                string nhaxb = txt_nhaxb.Text.Trim();
                string namxb = txt_namxb.Text.Trim();
                if (txt_masach.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập mã", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_masach.Focus();
                }
                else if (txt_tensach.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập tên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_tensach.Focus();
                }
                else if (txt_tacgia.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập tác giả", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_tacgia.Focus();
                }
                else if (txt_nhaxb.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập nhà xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nhaxb.Focus();
                }
                else if (txt_namxb.Text == "")
                {
                    MessageBox.Show("bạn chưa nhập năm xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_namxb.Focus();
                }
                
                else
                {
                    string sl_them = "INSERT INTO sach  (masach,tensach,tacgia,nhaxuatban,namxuatban) VALUES('" + masach + "','" + tensach + "','" + tacgia + "','" + nhaxb + "','" + namxb + "')";
                    ketnoi.thucthi(sl_them);
                    string selecttv = "select * from sach";
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string xoama = txt_masach.Text.Trim();
            DialogResult dlr = MessageBox.Show("bạn có chắc muốn xóa chứ", "thông báo",MessageBoxButtons.YesNo);
            if(dlr ==DialogResult.Yes)
            {
                string selectsach = "select masach from sach where masach ='"+xoama+"'";
                DataTable rm = ketnoi.truyvan(selectsach);
                string masach = rm.Rows[0][0].ToString();
                string dellma = "delete from sach where masach = '" + txt_masach.Text + "'";
                ketnoi.thucthi(dellma);
                string selecttv = "select * from sach";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
            }    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            txt_masach.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
           txt_tensach.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
           txt_tacgia.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txt_nhaxb.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
           txt_namxb.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            this.bt_them.Enabled = false;
            this.bt_sua.Enabled = true;
            this.bt_xoa.Enabled = true;


        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string masach = txt_masach.Text.Trim();
                string tensach = txt_tensach.Text.Trim();
                string tacgia = txt_tacgia.Text.Trim();
                string nhaxb = txt_nhaxb.Text.Trim();
                string namxb = txt_namxb.Text.Trim();
                string updatesach = "update sach set tensach = '" + tensach+ "',tacgia='" +  tacgia+ "',nhaxuatban='" +nhaxb+ "',namxuatban='" + namxb+ "'where sach.masach = '" + masach+ "'";
                ketnoi.thucthi(updatesach);
                string selecttv = "select * from sach";
                DataTable dt = ketnoi.truyvan(selecttv);
                dataGridView1.DataSource = dt;
                MessageBox.Show("đã sửa lại thành công");
            }
            catch(Exception )
            {
                MessageBox.Show("lỗi", "cảnh báo", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.bt_them.Enabled = true;
            this.bt_huy.Enabled = true;
            this.bt_sua.Enabled = false;
            this.bt_xoa.Enabled = false;

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            txt_masach.ResetText();
              txt_tensach.ResetText();
            txt_tacgia.ResetText();
            txt_nhaxb.ResetText();
            txt_namxb.ResetText();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
         DialogResult dlr =  MessageBox.Show("bạn có muốn thoát chứ", "thông bấo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                this.Close();
            }    

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

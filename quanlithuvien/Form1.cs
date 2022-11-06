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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txt_tk.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tài khoản", "thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt_tk.Focus();
            }  
            else if(txt_mk.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
            else if(!(txt_tk.Text =="admin" && txt_mk.Text == "123456"))
            {
                MessageBox.Show("bạn đã nhập sai", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tk.Focus();
                txt_mk.Focus();
            }  
            else
            {
                MessageBox.Show("đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                Form mdi = new MFI();
                mdi.ShowDialog();

            }    
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

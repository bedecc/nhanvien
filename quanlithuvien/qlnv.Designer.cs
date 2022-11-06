
namespace quanlithuvien
{
    partial class qlnv
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_huy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.qLTVDataSet5 = new quanlithuvien.QLTVDataSet5();
            this.qLTVDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet5BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new quanlithuvien.QLTVDataSet5TableAdapters.nhanvienTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_gioitinh);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 215);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhập thông tin nhân viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(126, 34);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(272, 27);
            this.txt_manv.TabIndex = 1;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(126, 100);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(272, 27);
            this.txt_tennv.TabIndex = 2;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(126, 166);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(272, 27);
            this.txt_sdt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(593, 126);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(272, 67);
            this.txt_diachi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "mã nv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "sdt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "tên nv";
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(510, 298);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(115, 45);
            this.bt_huy.TabIndex = 26;
            this.bt_huy.Text = "hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "quản lý nhân viên";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(840, 298);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(115, 45);
            this.bt_thoat.TabIndex = 23;
            this.bt_thoat.Text = "thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(345, 298);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(115, 45);
            this.bt_xoa.TabIndex = 22;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(180, 298);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(115, 45);
            this.bt_sua.TabIndex = 21;
            this.bt_sua.Text = "sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(675, 298);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(115, 45);
            this.bt_them.TabIndex = 20;
            this.bt_them.Text = "lưu";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 200);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellBorderStyleChanged += new System.EventHandler(this.dataGridView1_CellBorderStyleChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(593, 51);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(283, 28);
            this.cbb_gioitinh.TabIndex = 16;
            // 
            // qLTVDataSet5
            // 
            this.qLTVDataSet5.DataSetName = "QLTVDataSet5";
            this.qLTVDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTVDataSet5BindingSource
            // 
            this.qLTVDataSet5BindingSource.DataSource = this.qLTVDataSet5;
            this.qLTVDataSet5BindingSource.Position = 0;
            // 
            // qLTVDataSet5BindingSource1
            // 
            this.qLTVDataSet5BindingSource1.DataSource = this.qLTVDataSet5;
            this.qLTVDataSet5BindingSource1.Position = 0;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.qLTVDataSet5;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // qlnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Name = "qlnv";
            this.Text = "qlnv";
            this.Load += new System.EventHandler(this.qlnv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet5BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.BindingSource qLTVDataSet5BindingSource;
        private QLTVDataSet5 qLTVDataSet5;
        private System.Windows.Forms.BindingSource qLTVDataSet5BindingSource1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QLTVDataSet5TableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}
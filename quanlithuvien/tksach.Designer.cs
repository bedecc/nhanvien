
namespace quanlithuvien
{
    partial class tksach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new quanlithuvien.QLTVDataSet();
            this.cbb_masach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_masach = new System.Windows.Forms.Button();
            this.bt_tacgia = new System.Windows.Forms.Button();
            this.sachTableAdapter = new quanlithuvien.QLTVDataSetTableAdapters.sachTableAdapter();
            this.qLTVDataSet1 = new quanlithuvien.QLTVDataSet1();
            this.qLTVDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter1 = new quanlithuvien.QLTVDataSet1TableAdapters.sachTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "sach";
            this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbb_masach
            // 
            this.cbb_masach.DataSource = this.sachBindingSource;
            this.cbb_masach.DisplayMember = "masach";
            this.cbb_masach.FormattingEnabled = true;
            this.cbb_masach.Location = new System.Drawing.Point(235, 65);
            this.cbb_masach.Name = "cbb_masach";
            this.cbb_masach.Size = new System.Drawing.Size(289, 24);
            this.cbb_masach.TabIndex = 2;
            this.cbb_masach.ValueMember = "masach";
            this.cbb_masach.SelectedIndexChanged += new System.EventHandler(this.cbb_masach_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = " tác giả";
            // 
            // bt_masach
            // 
            this.bt_masach.Location = new System.Drawing.Point(569, 59);
            this.bt_masach.Name = "bt_masach";
            this.bt_masach.Size = new System.Drawing.Size(187, 29);
            this.bt_masach.TabIndex = 5;
            this.bt_masach.Text = "tìm mã sách";
            this.bt_masach.UseVisualStyleBackColor = true;
            this.bt_masach.Click += new System.EventHandler(this.bt_masach_Click);
            // 
            // bt_tacgia
            // 
            this.bt_tacgia.Location = new System.Drawing.Point(569, 109);
            this.bt_tacgia.Name = "bt_tacgia";
            this.bt_tacgia.Size = new System.Drawing.Size(187, 29);
            this.bt_tacgia.TabIndex = 6;
            this.bt_tacgia.Text = "tìm tác giả";
            this.bt_tacgia.UseVisualStyleBackColor = true;
            this.bt_tacgia.Click += new System.EventHandler(this.bt_tacgia_Click);
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // qLTVDataSet1
            // 
            this.qLTVDataSet1.DataSetName = "QLTVDataSet1";
            this.qLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTVDataSet1BindingSource
            // 
            this.qLTVDataSet1BindingSource.DataSource = this.qLTVDataSet1;
            this.qLTVDataSet1BindingSource.Position = 0;
            // 
            // sachBindingSource1
            // 
            this.sachBindingSource1.DataMember = "sach";
            this.sachBindingSource1.DataSource = this.qLTVDataSet1BindingSource;
            // 
            // sachTableAdapter1
            // 
            this.sachTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "tìm kiếm thông tin sách";
            // 
            // tksach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_tacgia);
            this.Controls.Add(this.bt_masach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_masach);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tksach";
            this.Text = "tksach";
            this.Load += new System.EventHandler(this.tksach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_masach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_masach;
        private System.Windows.Forms.Button bt_tacgia;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLTVDataSetTableAdapters.sachTableAdapter sachTableAdapter;
        private System.Windows.Forms.BindingSource qLTVDataSet1BindingSource;
        private QLTVDataSet1 qLTVDataSet1;
        private System.Windows.Forms.BindingSource sachBindingSource1;
        private QLTVDataSet1TableAdapters.sachTableAdapter sachTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}
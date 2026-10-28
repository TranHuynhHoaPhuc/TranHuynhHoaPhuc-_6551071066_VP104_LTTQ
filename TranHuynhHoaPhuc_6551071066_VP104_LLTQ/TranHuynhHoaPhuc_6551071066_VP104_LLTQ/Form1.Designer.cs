namespace TranHuynhHoaPhuc_6551071066_VP104_LLTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtLuongCoBan = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            lblLuongCoBan = new Label();
            lblTenNV = new Label();
            lblMaNV = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            dgvNhanVien = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(lblLuongCoBan);
            groupBox1.Controls.Add(lblTenNV);
            groupBox1.Controls.Add(lblMaNV);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(150, 141);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(231, 31);
            txtLuongCoBan.TabIndex = 5;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(150, 93);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(231, 31);
            txtTenNV.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(150, 43);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(231, 31);
            txtMaNV.TabIndex = 3;
            // 
            // lblLuongCoBan
            // 
            lblLuongCoBan.AutoSize = true;
            lblLuongCoBan.Location = new Point(25, 144);
            lblLuongCoBan.Name = "lblLuongCoBan";
            lblLuongCoBan.Size = new Size(126, 25);
            lblLuongCoBan.TabIndex = 2;
            lblLuongCoBan.Text = "Lương cơ bản:";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(25, 93);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(123, 25);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(25, 43);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(122, 25);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(444, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(444, 42);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 150);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(173, 111);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(173, 53);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(11, 114);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(11, 53);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvNhanVien);
            groupBox4.Location = new Point(3, 220);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(795, 292);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(0, 30);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(686, 225);
            dgvNhanVien.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 511);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản Lý Nhân Viên/Nhân Sự-VP104";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label lblLuongCoBan;
        private Label lblTenNV;
        private Label lblMaNV;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox4;
        private DataGridView dgvNhanVien;
    }
}

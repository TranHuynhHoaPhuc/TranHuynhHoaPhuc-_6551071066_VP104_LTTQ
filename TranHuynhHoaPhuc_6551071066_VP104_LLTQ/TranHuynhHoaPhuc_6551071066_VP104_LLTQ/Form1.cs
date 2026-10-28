
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TranHuynhHoaPhuc_6551071066_VP104_LLTQ.Models;

namespace TranHuynhHoaPhuc_6551071066_VP104_LLTQ
{
    public partial class Form1 : Form
    {
        private string? maTBChon;
        private bool dangTaiDuLieu = false;

        public Form1()
        {
            InitializeComponent();

         
            Load += Form1_Load;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            

            
        }

       
        private void Form1_Load(object? sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;

            txtMaNV.ReadOnly = false;

            dgvNhanVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.AllowUserToAddRows = false;

            TaiDuLieu();
        }

        // 2. Tải dữ liệu lên DataGridView
        private void TaiDuLieu()
        {
            try
            {
                dangTaiDuLieu = true;

                using (var db = new DuLieu_NhanSuContext())
                {
                    dgvNhanVien.DataSource = db.Set<NhanVien>()
                        .Select(s => new
                        { MaNhanVien = s.MaNhanVien,
                          TenNhanVien = s.TenNhanVien,
                          LuongCoBan=s.LuongCoBan
                        })
                        .AsNoTracking()
                        .ToList();
                }

                dgvNhanVien.ClearSelection();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                dangTaiDuLieu = false;
            }
        }

        // 3. Xóa trắng các ô nhập
        private void XoaTrang()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtLuongCoBan.Clear();
           
          
            txtMaNV.ReadOnly = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvNhanVien.ClearSelection();
            txtMaNV.Focus();
        }

        // 4. Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu()
          
        {
          

            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNV.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtLuongCoBan.Text))
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản!");
                txtLuongCoBan.Focus();
                return false;
            }





            return true;
        }


        // 6. Thêm thiết bị
        private void btnThem_Click(object? sender, EventArgs e)
        {
 

            try
            {
                using (var db = new DuLieu_NhanSuContext())
                {
                    string ma = txtMaNV.Text.Trim();

                    bool daTonTai = db.Set<NhanVien>()
                        .Any(s => s.MaNhanVien == ma);

                    if (daTonTai)
                    {
                        MessageBox.Show("mã nhân viên đã tồn tại!");
                        txtMaNV.Focus();
                        return;
                    }

                    var tb = new NhanVien
                    {
                        MaNhanVien = ma,
                        TenNhanVien = txtTenNV.Text.Trim(),
                        LuongCoBan = txtLuongCoBan.Text.Trim(),


                    };

                    db.Set<NhanVien>().Add(tb);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm nhân viên thành công!");
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm nhân viên: " + ex.Message);
            }
        }

        // 7. Chọn một dòng trong DataGridView
        private void dgvNhanVien_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (dangTaiDuLieu || e.RowIndex < 0)
                return;

            var row = dgvNhanVien.Rows[e.RowIndex];

            if (row.Cells["MaNhanVien"].Value == null)
                return;

            maTBChon = row.Cells["MaNhanVien"].Value.ToString();

            txtMaNV.Text = maTBChon;
            txtTenNV.Text =
                row.Cells["TenNhanVien"].Value?.ToString() ?? "";

            txtLuongCoBan.Text =
                row.Cells["LuongCoBan"].Value?.ToString() ?? "";

  

            txtMaNV.ReadOnly = true;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

    
        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maTBChon))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên cần sửa!");
                return;
            }


                return;

            try
            {
                using (var db = new DuLieu_NhanSuContext())
                {
                    var tb = db.Set<NhanVien>()
                        .FirstOrDefault(s => s.MaNhanVien == maTBChon);

                    if (tb == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                        TaiDuLieu();
                        return;
                    }

                    tb.TenNhanVien = txtTenNV.Text.Trim();
                    tb.LuongCoBan = txtLuongCoBan.Text.Trim();





                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật nhân viên thành công!");
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi sửa nhân viên: " + ex.Message);
            }
        }

        
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maTBChon))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                using (var db = new DuLieu_NhanSuContext())
                {
                    var tb = db.Set<NhanVien>()
                        .FirstOrDefault(s => s.MaNhanVien == maTBChon);

                    if (tb == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                        TaiDuLieu();
                        return;
                    }

                    db.Set<NhanVien>().Remove(tb);
                    db.SaveChanges();
                }

                MessageBox.Show("Xóa nhân viên!");
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xóa nhân viên: " + ex.Message);
            }
        }


        private void btnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
                Close();
        }
    }
}

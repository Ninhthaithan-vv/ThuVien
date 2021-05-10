using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVWF.Database;
namespace QLTVWF
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
        }

        private void txbTenDS_OnValueChanged(object sender, EventArgs e)
        {

        }
        public void Load_DG()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var listDG = qltv.Database.SqlQuery<ThongTinDocGia>($"exec LoadThongTinDocGia");
                dtgv_loadDG.DataSource = listDG.ToList();

            }
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            Load_DG();
        }
        public void TrangThaiBanDau()
        {
            btThemDG.Enabled = true;
            btSuaDG.Enabled = true;
            btXoaDG.Enabled = true;
            btLuuDG.Enabled = false;
            btHuyDG.Enabled = false;
            txbMaDG.Enabled = false;
            txbTenDG.Enabled = false;
            txbDonViDG.Enabled = false;
            dtpNgaySinhDG.Enabled = false;
            txbSdtDG.Enabled = false;
            dtpNgayDK.Enabled = false;
            dtpNgayHH.Enabled = false;
            txbLoaiDG.Enabled = false;
            txbTaiKhoanDG.Enabled = false;
            txbMatKhauDG.Enabled = false;
        }

      
        private void dtgv_loadDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                TrangThaiBanDau();
                int i = e.RowIndex;
                txbMaDG.Text = dtgv_loadDG.Rows[i].Cells[0].Value.ToString();
                txbTenDG.Text = dtgv_loadDG.Rows[i].Cells[1].Value.ToString();
                dtpNgaySinhDG.Text = dtgv_loadDG.Rows[i].Cells[2].Value.ToString();
                txbDonViDG.Text = dtgv_loadDG.Rows[i].Cells[3].Value.ToString();
                txbSdtDG.Text = dtgv_loadDG.Rows[i].Cells[4].Value.ToString();
                dtpNgayDK.Text = dtgv_loadDG.Rows[i].Cells[5].Value.ToString();
                dtpNgayHH.Text = dtgv_loadDG.Rows[i].Cells[6].Value.ToString();
                TaiKhoanDG TK = qltv.TaiKhoanDGs.Where(p => p.MaDocGia == txbMaDG.Text).FirstOrDefault();
                txbTaiKhoanDG.Text = TK.TenDangNhap;
                txbMatKhauDG.Text = TK.MatKhau;
                if (dtgv_loadDG.Rows[i].Cells[7].Value == null) txbLoaiDG.Text = "NULL";
                else txbLoaiDG.Text = dtgv_loadDG.Rows[i].Cells[7].Value.ToString();
            }
        }
        bool ThemOrSua;
        bool KiemTraThongTinNhap()
        {
            if (txbMaDG.Text == "") MessageBox.Show("Ban chua nhap ma doc gia!");
            else if (txbTenDG.Text == "") MessageBox.Show("Ban chua nhap ten doc gia!");
            else if (txbDonViDG.Text == "") MessageBox.Show("Ban chua nhap don vi doc gia!");
            else if (dtpNgaySinhDG.Text == "") MessageBox.Show("Ban chua nhap ngay sinh doc gia!");
            else if (txbSdtDG.Text == "") MessageBox.Show("Ban chua nhap so dien thoai doc gia!");
            else if (dtpNgayDK.Text == "") MessageBox.Show("Ban chua nhap ngay dang ky!");
            else if (dtpNgayHH.Text == "") MessageBox.Show("Ban chua nhap ngay het han!");
            else if (txbLoaiDG.Text == "") MessageBox.Show("Ban chua nhap loai doc gia!");
            else if (txbTaiKhoanDG.Text == "") MessageBox.Show("Ban chua nhap tai khoan!");
            else if (txbMatKhauDG.Text == "") MessageBox.Show("Ban chua nhap mat khau!");
            else return true;
            return false;
        }
        private void btLuuDG_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                if (ThemOrSua == true)
                {
                    bool madg = false;
                    bool matk = false;
                    var listMaDG = from kq in qltv.DocGias select kq.MaDocGia;
                    var listMaTK = from kq in qltv.TaiKhoanDGs select kq.TenDangNhap;
                    foreach (var item in listMaDG)
                    {
                        if (txbMaDG.Text == item) madg = true;
                    }
                    foreach (var item in listMaTK)
                    {
                        if (txbMaDG.Text == item) matk = true;
                    }
                    if (txbMaDG.Text == "") MessageBox.Show("Ban chua nhap ma doc gia!");
                    else if (txbTenDG.Text == "") MessageBox.Show("Ban chua nhap ten doc gia!");
                    else if (txbDonViDG.Text == "") MessageBox.Show("Ban chua nhap don vi doc gia!");
                    else if (dtpNgaySinhDG.Text == "") MessageBox.Show("Ban chua nhap ngay sinh doc gia!");
                    else if (txbSdtDG.Text == "") MessageBox.Show("Ban chua nhap so dien thoai doc gia!");
                    else if (dtpNgayDK.Text == "") MessageBox.Show("Ban chua nhap ngay dang ky!");
                    else if (dtpNgayHH.Text == "") MessageBox.Show("Ban chua nhap ngay het han!");
                    else if (txbLoaiDG.Text == "") MessageBox.Show("Ban chua nhap loai doc gia!");
                    else if (txbTaiKhoanDG.Text == "") MessageBox.Show("Ban chua nhap tai khoan!");
                    else if (txbMatKhauDG.Text == "") MessageBox.Show("Ban chua nhap mat khau!");
                    else if (madg == true) MessageBox.Show("Ma doc gia nay da ton tai!");
                    else if (matk == true) MessageBox.Show("Ten tai khoan nay da ton tai!");
                    else
                    {
                        try
                        {
                            qltv.Database.ExecuteSqlCommand($"exec ThemDocGia '{txbMaDG.Text}',N'{txbTenDG.Text}','{dtpNgaySinhDG.Text}',N'{txbDonViDG.Text}','{txbSdtDG.Text}','{dtpNgayDK.Text}','{dtpNgayHH.Text}',N'{txbLoaiDG.Text}'");
                            qltv.Database.ExecuteSqlCommand($"exec ThemTaiKhoanDG '{txbMaDG.Text}','{txbTaiKhoanDG.Text}','{txbMatKhauDG.Text}'");
                            MessageBox.Show("Them thanh cong doc gia");
                            Load_DG();
                            TrangThaiBanDau();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Ma doc gia phai duoc bat dau bang 'DG' !");
                        }
                    }
                }
                else
                {
                    qltv.Database.ExecuteSqlCommand($"exec SuaTaiKhoanDG '{txbMaDG.Text}','{txbMatKhauDG.Text}'");
                    qltv.Database.ExecuteSqlCommand($"exec SuaDocGia '{txbMaDG.Text}',N'{txbTenDG.Text}','{dtpNgaySinhDG.Text}',N'{txbDonViDG.Text}','{txbSdtDG.Text}','{dtpNgayDK.Text}','{dtpNgayHH.Text}',N'{txbLoaiDG.Text}'");
                    MessageBox.Show("Sua thanh cong");
                    Load_DG();
                    TrangThaiBanDau();
                }
            }
        }

        private void btHuyDG_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                if (rdbMaDG.Checked == true)
                {
                    var listDG = qltv.ThongTinDocGias.SqlQuery($"exec TimKiemDocGia_TheoMa '{txbTimKiem.Text}'");
                    dtgv_loadDG.DataSource = listDG.ToList();
                }
                else if (rdbTenDG.Checked == true)
                {
                    var listDG = qltv.ThongTinDocGias.SqlQuery($"exec TimKiemDocGia_TheoTen N'{txbTimKiem.Text}'");
                    dtgv_loadDG.DataSource = listDG.ToList();
                }
            }

        }
        void TrangThaiThemOrSuaDG()
        {
            btThemDG.Enabled = false;
            btSuaDG.Enabled = false;
            btXoaDG.Enabled = false;
            btLuuDG.Enabled = true;
            btHuyDG.Enabled = true;    
            txbTenDG.Enabled = true;
            txbDonViDG.Enabled = true;
            dtpNgaySinhDG.Enabled = true;
            txbSdtDG.Enabled = true;
            dtpNgayDK.Enabled = true;
            dtpNgayHH.Enabled = true;
            txbLoaiDG.Enabled = true;
            txbMatKhauDG.Enabled = true;
        }
        private void btThemDG_Click(object sender, EventArgs e)
        {

            ThemOrSua = true;
            TrangThaiThemOrSuaDG();
            txbMaDG.Enabled = true;
            txbTaiKhoanDG.Enabled = true;
            txbMaDG.Text = "";
            txbTenDG.Text = "";
            txbDonViDG.Text = "";
            txbSdtDG.Text = "";
            txbLoaiDG.Text = "";
            txbTaiKhoanDG.Text = "";
            txbMatKhauDG.Text = "";
        }

        private void btSuaDG_Click(object sender, EventArgs e)
        {
            ThemOrSua = false;
            TrangThaiThemOrSuaDG();
        }

       

 
 

        private void btXoaDG_Click(object sender, EventArgs e)
        {

        }
    }
}

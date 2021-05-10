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
    public partial class ThayDoiThongTinNhanVIen : Form
    {
        public ThayDoiThongTinNhanVIen()
        {
            InitializeComponent();
        }

        private void ThayDoiThongTinNhanVIen_Load(object sender, EventArgs e)
        {
            Load_NV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Load_NV()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                NhanVien NV = qltv.NhanViens.Where(p => p.MaNhanVien == "NV001").FirstOrDefault();
                ChucVu CV = qltv.ChucVus.Where(p => p.MaChucVu == NV.MaChucVu).FirstOrDefault();
                txbMaNV.Text = NV.MaNhanVien;
                txbTenNV.Text = NV.HoTen;
                txbSDTNV.Text = NV.SDT;
                dTP_NgaySinhNV.Text = NV.NgaySinh.ToString();
                cbbChucVu.Text = CV.TenChucVu;
            }
        }
        void Load_ChucVu()
        {
            using(Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var TenCV = from kq in qltv.ChucVus select kq.TenChucVu;
                cbbChucVu.DataSource = TenCV.ToList();
            }
        }

        private void linklb_ThayDoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbTenNV.Enabled = true;
            txbSDTNV.Enabled = true;
            cbbChucVu.Enabled = true;
            dTP_NgaySinhNV.Enabled = true;
            btLuu.Visible = true;
            btHuy.Visible = true;
            Load_ChucVu();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                ChucVu cv = qltv.ChucVus.Where(p => p.TenChucVu == cbbChucVu.Text).FirstOrDefault();
                qltv.Database.ExecuteSqlCommand($"exec SuaNhanVien '{txbMaNV.Text}',N'{txbTenNV.Text}','{dTP_NgaySinhNV.Text}','{txbSDTNV.Text}','{cv.MaChucVu}'");
                MessageBox.Show("Thay đổi thành công !!!");
                btHuy.Visible = false;
                btLuu.Visible = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txbTenNV.Enabled = false;
            txbSDTNV.Enabled = false;
            cbbChucVu.Enabled = false;
            dTP_NgaySinhNV.Enabled = false;
            btLuu.Visible = false;
            btHuy.Visible = false;
        }

      
    }
}

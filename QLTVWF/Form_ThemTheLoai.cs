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
    public partial class Form_ThemTheLoai : Form
    {
        public Form_ThemTheLoai()
        {
            InitializeComponent();
        }
        private void Form_ThemTheLoai_Load(object sender, EventArgs e)
        {
            Load_TheLoai();
        }
        void Load_TheLoai()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                btLuu.Enabled = false;
                btThem.Enabled = true;
                btXoa.Enabled = true;
                var listTheLoai = qltv.Database.SqlQuery<TT_TheLoai_DauSach>($"exec  LoadThongTinTheLoai_CuaDauSach '{QuanLyDauSach.MaDS}'");
                dtGV_TheLoai.DataSource = listTheLoai.ToList();
            }
        }
        void Load_MaTheLoai()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var listMaTheLoai = from kq in qltv.TheLoais select kq.MaTheLoai;
                cbbMaTheLoai.DataSource = listMaTheLoai.ToList();
            }
        }

        private void cbbMaTheLoai_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var listMaTheLoai = from kq in qltv.TheLoais select kq.MaTheLoai;
                bool tmt = false;
                foreach (var item in listMaTheLoai) { if (cbbMaTheLoai.Text == item) tmt = true; }
                if (tmt == true)
                {
                    TheLoai TL = qltv.TheLoais.Where(p => p.MaTheLoai == cbbMaTheLoai.Text).SingleOrDefault();
                    txbTenTheLoai.Enabled = false;
                    txbTenTheLoai.Text = TL.TenTheLoai;
                    txbViTriVaiTro.Text = "";
                }
                else
                {
                    txbTenTheLoai.Enabled = true;
                    txbTenTheLoai.Text = "";
                    txbViTriVaiTro.Text = "";
                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                bool tmt = false;
                var ListMaTL = from kq in qltv.TheLoais select kq.MaTheLoai;
                foreach (var item in ListMaTL) { if (cbbMaTheLoai.Text == item) tmt = true; }
                if (tmt == true)
                {
                    try
                    {
                        qltv.Database.ExecuteSqlCommand($"exec ThemTheLoaiDauSach '{QuanLyDauSach.MaDS}','{cbbMaTheLoai.Text}',{txbViTriVaiTro.Text}");
                        MessageBox.Show("Them thanh cong The Loai");
                        Load_TheLoai();
                        TrangThaiBanDau();
                    }
                    catch (Exception) { MessageBox.Show("The loai da ton tai!"); }
                }
                else
                {
                    qltv.Database.ExecuteSqlCommand($"exec ThemTheLoai '{cbbMaTheLoai.Text}',N'{txbTenTheLoai.Text}'");
                    qltv.Database.ExecuteSqlCommand($"exec ThemTheLoaiDauSach '{QuanLyDauSach.MaDS}','{cbbMaTheLoai.Text}',{txbViTriVaiTro.Text}");
                    MessageBox.Show("Them thanh cong The Loai");
                    Load_TheLoai();
                    TrangThaiBanDau();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void TrangThaiBanDau()
        {
            cbbMaTheLoai.Enabled = false;
            txbTenTheLoai.Enabled = false;
            txbViTriVaiTro.Enabled = false;
            btLuu.Enabled = false;
            btXoa.Enabled = true;
            btThem.Enabled = true;
        }
        private void dtGV_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            TrangThaiBanDau();
            cbbMaTheLoai.Text = dtGV_TheLoai.Rows[i].Cells[0].Value.ToString();
            txbTenTheLoai.Text = dtGV_TheLoai.Rows[i].Cells[1].Value.ToString();
            txbViTriVaiTro.Text = dtGV_TheLoai.Rows[i].Cells[2].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            btXoa.Enabled = false;
            btThem.Enabled = false;
            cbbMaTheLoai.Enabled = true;
            txbTenTheLoai.Enabled = true;
            txbViTriVaiTro.Enabled = true;
            Load_MaTheLoai();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                qltv.Database.ExecuteSqlCommand($"exec XoaTheLoai '{QuanLyDauSach.MaDS}','{cbbMaTheLoai.Text}'");
                MessageBox.Show("Xoa thanh cong the loai");
                Load_TheLoai();
            }
        }
    }
}

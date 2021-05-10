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
    public partial class Form_ThemTacGia : Form
    {
        public Form_ThemTacGia()
        {
            InitializeComponent();
        }
        void Load_TacGia()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                btLuu.Enabled = false;
                btThem.Enabled = true;
                btXoa.Enabled = true;
                var listTg = qltv.Database.SqlQuery<TT_TacGia_DauSach>($"exec LoadThongTinTacGia_CuaDauSach '{QuanLyDauSach.MaDS}'");
                dtGV_TacGia.DataSource = listTg.ToList();
            }
        }
        private void Form_ThemTacGia_Load(object sender, EventArgs e)
        {
            Load_TacGia();
        }
        void Load_MaTG()
        {
            using (var qltv = new Model_QuanLi_ThuVien())
            {
                var ListMaTG = from kq in qltv.TacGias select kq.MaTacGia;
                cbbMaTG.DataSource = ListMaTG.ToList();
            }
        }

        private void cbbMaTG_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                bool tmt = false;
                var ListMaTG = from kq in qltv.TacGias select kq.MaTacGia;
                foreach (var item in ListMaTG)
                {
                    if (cbbMaTG.Text == item)
                    {
                        tmt = true;
                    }

                }
                if (tmt == true)
                {
                    TacGia TG = qltv.TacGias.Where(p => p.MaTacGia == cbbMaTG.Text).SingleOrDefault();
                    var ViTri = from kq in qltv.SangTacs where kq.MaDauSach == QuanLyDauSach.MaDS && kq.MaTacGia == cbbMaTG.Text select kq.ViTriVaiTro;
                    txbTenTG.Text = TG.TenTacGia;
                    dTP_NgaySinhTG.Text = TG.NgaySinh.ToString();
                    txbViTriVaiTro.Text = "";
                    dTP_NgaySinhTG.Enabled = false;
                    txbTenTG.Enabled = false;
                }
                else
                {
                    txbTenTG.Enabled = true;
                    dTP_NgaySinhTG.Enabled = true;
                    txbTenTG.Text = "";
                    txbViTriVaiTro.Text = "";
                    dTP_NgaySinhTG.Value = DateTime.Now;
                }

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                bool tmt = false;
                var ListMaTG = from kq in qltv.TacGias select kq.MaTacGia;
                foreach (var item in ListMaTG) { if (cbbMaTG.Text == item) tmt = true; }
                if (tmt == true)
                {
                    try
                    {
                        qltv.Database.ExecuteSqlCommand($"exec ThemSangTac '{QuanLyDauSach.MaDS}','{cbbMaTG.Text}',{txbViTriVaiTro.Text}");
                        MessageBox.Show("Them thanh cong tac gia");
                        Load_TacGia();
                        TrangThaiBanDau();

                    }
                    catch (Exception) { MessageBox.Show("Tac gia nay da ton tai"); }
                }
                else
                {
                    qltv.Database.ExecuteSqlCommand($"exec ThemTacGia '{cbbMaTG.Text}',N'{txbTenTG.Text}','{dTP_NgaySinhTG.Text}'");
                    qltv.Database.ExecuteSqlCommand($"exec ThemSangTac '{QuanLyDauSach.MaDS}','{cbbMaTG.Text}',{txbViTriVaiTro.Text}");
                    MessageBox.Show("Them thanh cong tac gia");
                    Load_TacGia();
                    TrangThaiBanDau();
                }
            }
        }

        private void dtGV_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            TrangThaiBanDau();
            cbbMaTG.Text = dtGV_TacGia.Rows[i].Cells[0].Value.ToString();
            txbTenTG.Text = dtGV_TacGia.Rows[i].Cells[1].Value.ToString();
            dTP_NgaySinhTG.Text = dtGV_TacGia.Rows[i].Cells[2].Value.ToString();
            txbViTriVaiTro.Text = dtGV_TacGia.Rows[i].Cells[3].Value.ToString();
        }
        void TrangThaiBanDau()
        {
            cbbMaTG.Enabled = false;
            txbTenTG.Enabled = false;
            dTP_NgaySinhTG.Enabled = false;
            txbViTriVaiTro.Enabled = false;
            btLuu.Enabled = false;
            btXoa.Enabled = true;
            btThem.Enabled = true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            btXoa.Enabled = false;
            btThem.Enabled = false;
            cbbMaTG.Enabled = true;
            txbTenTG.Enabled = true;
            dTP_NgaySinhTG.Enabled = true;
            txbViTriVaiTro.Enabled = true;
            Load_MaTG();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                qltv.Database.ExecuteSqlCommand($"exec XoaSangTac '{QuanLyDauSach.MaDS}','{cbbMaTG.Text}'");
                MessageBox.Show("Xoa thanh cong tac gia");
                Load_TacGia();
            }
        }


    }
}


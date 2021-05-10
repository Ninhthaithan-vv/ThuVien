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
    public partial class QuanLyCuonSach : Form
    {
        public QuanLyCuonSach()
        {
            InitializeComponent();
            Load_CuonSach();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.IconColor = Color.FromArgb(233, 49, 1);

        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.IconColor = Color.FromArgb(53, 234, 31);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Load_CuonSach()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var ListCS = qltv.Database.SqlQuery<TT_CuonSach>($"exec LoadThongTinCuonSach @MaDauSach='{QuanLyDauSach.MaDS}'");
                dtGV_CuonSach.DataSource = ListCS.ToList();
            }
        }
        void Load_MaViTri()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var listMaVT = from kq in qltv.ViTriSaches select kq.MaViTri;
                cbbMaVT.DataSource = listMaVT.ToList();
            }
        }
        void TrangThaiBanDau()
        {
            txbTimKiemCS.Enabled = true;
            txbMaCS.Enabled = false;
            cbbMaVT.Visible = false;
            lbMaVT.Visible = false;
            cbbMaVT.Enabled = false;
            txbTenGiaSach.Enabled = false;
            txbTang.Enabled = false;
            txbNgan.Enabled = false;
            btLuuCS.Enabled = false;
            btHuy.Enabled = false;
            btThemCS.Enabled = true;
            btSuaCS.Enabled = true;
            btXoaCS.Enabled = true;
        }
        private void QuanLyCuonSach_Load(object sender, EventArgs e)
        {
            Load_CuonSach();
            lbTenSach.Text = QuanLyDauSach.TenDS;
        }

        private void dtGV_CuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                int i = e.RowIndex;
                TrangThaiBanDau();
                txbMaCS.Text = dtGV_CuonSach.Rows[i].Cells[0].Value.ToString();
                txbTenCS.Text = dtGV_CuonSach.Rows[i].Cells[1].Value.ToString();
                txbTinhTrangCS.Text = dtGV_CuonSach.Rows[i].Cells[2].Value.ToString();
                ThongTinCuonSach TTCS = qltv.ThongTinCuonSaches.Where(p => p.MaSach == txbMaCS.Text).SingleOrDefault();
                txbTenGiaSach.Text = TTCS.TenGiaSach;
                txbTang.Text = TTCS.Tang;
                txbNgan.Text = TTCS.Ngan;
            }
        }


        bool ThemOrSua;

        void TrangThaiThemOrSua()
        {
            cbbMaVT.Enabled = true;
            txbTenGiaSach.Enabled = true;
            txbTang.Enabled = true;
            txbNgan.Enabled = true;
            btLuuCS.Enabled = true;
            btHuy.Enabled = true;
            btThemCS.Enabled = false;
            btSuaCS.Enabled = false;
            btXoaCS.Enabled = false;
        }
        private void btThemCS_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                ThemOrSua = true;
                Load_MaViTri();
                TrangThaiThemOrSua();
                txbTimKiemCS.Enabled = false;
                txbMaCS.Enabled = true;
                cbbMaVT.Visible = true;
                lbMaVT.Visible = true;
                txbMaCS.Text = "";
                txbTinhTrangCS.Text = "true";
                cbbMaVT.Text = "";
                txbTenGiaSach.Text = "";
                txbTang.Text = "";
                txbNgan.Text = "";
            }
        }

        private void txbTimKiemCS_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var ListCS = qltv.Database.SqlQuery<TT_CuonSach>($"exec TimKiemCuonSach @MaDauSach='{QuanLyDauSach.MaDS}', @MaSach='{txbTimKiemCS.Text}'");
                dtGV_CuonSach.DataSource = ListCS.ToList();
            }
        }

        private void btSuaCS_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                Load_MaViTri();
                ThongTinCuonSach TTCS = qltv.ThongTinCuonSaches.Where(p => p.MaSach == txbMaCS.Text).SingleOrDefault();
                CuonSach CS = qltv.CuonSaches.Where(p => p.MaSach == txbMaCS.Text).SingleOrDefault();
                cbbMaVT.Text = CS.MaViTri;
                txbTenGiaSach.Text = TTCS.TenGiaSach;
                txbTang.Text = TTCS.Tang;
                txbNgan.Text = TTCS.Ngan;
                ThemOrSua = false;
                TrangThaiThemOrSua();
                cbbMaVT.Visible = true;
                lbMaVT.Visible = true;
            }
        }

        private void cbbMaVT_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                bool tmt = false;
                var listMaVT = from kq in qltv.ViTriSaches select kq.MaViTri;
                foreach (var item in listMaVT) { if (cbbMaVT.Text == item) tmt = true; }
                if (tmt == true)
                {
                    ViTriSach VTS = qltv.ViTriSaches.Where(p => p.MaViTri == cbbMaVT.Text).SingleOrDefault();
                    txbTenGiaSach.Text = VTS.TenGiaSach;
                    txbTang.Text = VTS.Tang;
                    txbNgan.Text = VTS.Ngan;
                    txbTenGiaSach.Enabled = false;
                    txbTang.Enabled = false;
                    txbNgan.Enabled = false;
                }
                else
                {
                    txbTenGiaSach.Text = "";
                    txbTang.Text = "";
                    txbNgan.Text = "";
                    txbTenGiaSach.Enabled = true;
                    txbTang.Enabled = true;
                    txbNgan.Enabled = true;
                }
            }
        }

        private void btLuuCS_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                if (txbMaCS.Text == "") MessageBox.Show("Chua nhap ma sach!");
                else if (cbbMaVT.Text == "") MessageBox.Show("Chua nhap ma vi tri!");
                else if (txbTenGiaSach.Text == "") MessageBox.Show("Chua nhap ten gia sach!");
                else if (txbTang.Text == "") MessageBox.Show("Chua nhap tang!");
                else if (txbNgan.Text == "") MessageBox.Show("Chua nhap ngan!");
                else
                {
                    if (ThemOrSua == true)
                    {
                        bool tmt = false;
                        var listMaSach = from kq in qltv.CuonSaches select kq.MaSach;
                        foreach (var item in listMaSach) { if (txbMaCS.Text == item) tmt = true; }
                        if (tmt == true) MessageBox.Show("Ma sach da ton tai!");
                        else
                        {
                            bool tmt1 = false;
                            var listMaVT = from kq1 in qltv.ViTriSaches select kq1.MaViTri;
                            foreach (var item in listMaVT) { if (cbbMaVT.Text == item) tmt1 = true; }
                            if (tmt1 == true)
                            {
                                qltv.Database.ExecuteSqlCommand($"exec ThemCuonSach '{txbMaCS.Text}','{QuanLyDauSach.MaDS}','{cbbMaVT.Text}'");
                                MessageBox.Show("Them thanh cong cuon sach");
                                Load_CuonSach();
                                TrangThaiBanDau();
                            }
                            else
                            {
                                qltv.Database.ExecuteSqlCommand($" exec ThemViTriSach '{cbbMaVT.Text}','{txbTenGiaSach.Text}','{txbTang.Text}','{txbNgan.Text}'");
                                qltv.Database.ExecuteSqlCommand($"exec ThemCuonSach '{txbMaCS.Text}','{QuanLyDauSach.MaDS}','{cbbMaVT.Text}'");
                                MessageBox.Show("Them thanh cong cuon sach");
                                Load_CuonSach();
                                TrangThaiBanDau();
                            }
                        }
                    }
                    else
                    {
                        bool tmt2 = false;
                        var listMaVT = from kq1 in qltv.ViTriSaches select kq1.MaViTri;
                        foreach (var item in listMaVT) { if (cbbMaVT.Text == item) tmt2 = true; }
                        if (tmt2 == true)
                        {
                            qltv.Database.ExecuteSqlCommand($"exec SuaCuonSach '{txbMaCS.Text}','{cbbMaVT.Text}'");
                            MessageBox.Show("Sua thanh cong cuon sach");
                            Load_CuonSach();
                            TrangThaiBanDau();
                        }
                        else
                        {
                            qltv.Database.ExecuteSqlCommand($" exec ThemViTriSach '{cbbMaVT.Text}','{txbTenGiaSach.Text}','{txbTang.Text}','{txbNgan.Text}'");
                            qltv.Database.ExecuteSqlCommand($"exec SuaCuonSach '{txbMaCS.Text}','{cbbMaVT.Text}'");
                            MessageBox.Show("Sua thanh cong cuon sach");
                            Load_CuonSach();
                            TrangThaiBanDau();
                        }
                    }
                }
            }
        }

        private void btXoaCS_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                CuonSach cs = qltv.CuonSaches.Where(p => p.MaSach == txbMaCS.Text).SingleOrDefault();
                if (cs.TinhTrang == false)
                {
                    MessageBox.Show("Cuon sach dang duoc cho muon! khong xoa duoc!");
                }
                else
                {
                    qltv.Database.ExecuteSqlCommand($"exec XoaCuonSach  '{txbMaCS.Text}' ");
                    MessageBox.Show("Xoa thanh cong cuon sach");
                    Load_CuonSach();
                }
            }
            TrangThaiBanDau();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txbMaCS.Text = "";
            txbTenCS.Text = "";
            txbTinhTrangCS.Text = "";
            cbbMaVT.Text = "";
            txbTenGiaSach.Text = "";
            txbTang.Text = "";
            txbNgan.Text = "";
            TrangThaiBanDau();
        }
    }
}

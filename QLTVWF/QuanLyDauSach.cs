using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVWF.Database;
namespace QLTVWF
{
    public partial class QuanLyDauSach : Form
    {
        public QuanLyDauSach()
        {
            InitializeComponent();
        }
        public static string MaDS;
        public static string TenDS;
        void Load_DauSach()
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                var ListDS = qltv.ThongTinDauSaches.SqlQuery("exec LoadThongTinDauSach");
                dtGV_DauSach.DataSource = ListDS.ToList();

            }

        }

        private void QuanLyDauSach_Load(object sender, EventArgs e)
        {
            Load_DauSach();
        }
        string textImagePath;
        byte[] Byte_HinhAnh;

        private void btShowCuonSach_Click(object sender, EventArgs e)
        {
            MaDS = txbMaDS.Text;
            TenDS = txbTenDS.Text;
            Form quanlycuonsach = new QuanLyCuonSach();
            quanlycuonsach.TopLevel = false;
            Backround_Panel.Controls.Add(quanlycuonsach);
            quanlycuonsach.Dock = DockStyle.Fill;
            Backround_Panel.Tag = quanlycuonsach;
            quanlycuonsach.BringToFront();
            quanlycuonsach.Show();
        }
        private void ptbAnhDS_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog OpenFDL = new OpenFileDialog();
            OpenFDL.Filter = OpenFDL.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            OpenFDL.FilterIndex = 1;
            OpenFDL.RestoreDirectory = true;
            if (OpenFDL.ShowDialog() == DialogResult.OK)
            {
                ptbAnhDS.ImageLocation = OpenFDL.FileName;
                textImagePath = OpenFDL.FileName.ToString();
            }
            Byte_HinhAnh = ConvertImageToBytes(textImagePath);
            ptbAnhDS.Image = ByteToImage(Byte_HinhAnh);
        }

        private byte[] ConvertImageToBytes(string text)
        {
            FileStream fs;
            fs = new FileStream(text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;

        }
        public static Image ByteToImage(byte[] arrImage)
        {
            if (arrImage == null)
            {
                MessageBox.Show("KO co anh");
                return null;
            }
            MemoryStream ms = new MemoryStream(arrImage, 0, arrImage.Length);
            ms.Write(arrImage, 0, arrImage.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        void TrangThaiBanDau()
        {
            btThemDs.Enabled = true;
            btSuaDS.Enabled = true;
            btXoaDS.Enabled = true;
            txbMaDS.Enabled = false;
            txbTenDS.Enabled = false;
            txbTenNXB.Enabled = false;
            dtbNXB.Enabled = false;
            txbSotrang.Enabled = false;
            txbSoLuong.Enabled = false;
            txbGiaTien.Enabled = false;
            ptbAnhDS.Enabled = false;
            btSuaTG.Visible = false;
            btSuaTL.Visible = false;
            btLuuDS.Enabled = false;
            btHuy.Enabled = false;
        }

        private void dtGV_DauSach_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                TrangThaiBanDau();
                int i = e.RowIndex;
                txbMaDS.Text = dtGV_DauSach.Rows[i].Cells[0].Value.ToString();
                MaDS = txbMaDS.Text;
                txbTenDS.Text = dtGV_DauSach.Rows[i].Cells[1].Value.ToString();
                txbTenNXB.Text = dtGV_DauSach.Rows[i].Cells[2].Value.ToString();
                dtbNXB.Text = dtGV_DauSach.Rows[i].Cells[3].Value.ToString();
                txbSotrang.Text = dtGV_DauSach.Rows[i].Cells[4].Value.ToString();
                txbGiaTien.Text = dtGV_DauSach.Rows[i].Cells[5].Value.ToString();
                txbSoLuong.Text = dtGV_DauSach.Rows[i].Cells[6].Value.ToString();
                var ListTG = from kq in qltv.SangTacs where kq.MaDauSach == txbMaDS.Text select kq.TacGia.TenTacGia;
                var ListTheLoai = from kq in qltv.TheLoaiDauSaches where kq.MaDauSach == txbMaDS.Text select kq.TheLoai.TenTheLoai;
                cbbTacGia.DataSource = ListTG.ToList();
                cbbTheLoai.DataSource = ListTheLoai.ToList();
                DauSach ds = qltv.DauSaches.Where(p => p.MaDauSach == txbMaDS.Text).FirstOrDefault();
                Byte_HinhAnh = (byte[])ds.HinhAnh;
                ptbAnhDS.Image = ByteToImage((byte[])ds.HinhAnh);
            }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                SqlParameter Search_Ma = new SqlParameter { ParameterName = "MaDauSach", Value = txbTimKiem.Text };
                SqlParameter Search_Ten = new SqlParameter { ParameterName = "TenDauSach", Value = txbTimKiem.Text };
                SqlParameter Search_TG = new SqlParameter { ParameterName = "TenTacGia", Value = txbTimKiem.Text };
                SqlParameter Search_TL = new SqlParameter { ParameterName = "TenTheLoai", Value = txbTimKiem.Text };
                if (rdbMaDS.Checked == true)
                {
                    var ListDS = qltv.ThongTinDauSaches.SqlQuery($"exec TimKiemDauSach_TheoMaDS @MaDauSach", Search_Ma);
                    dtGV_DauSach.DataSource = ListDS.ToList();
                }
                else if (rdbTenDS.Checked == true)
                {
                    var ListDS = qltv.ThongTinDauSaches.SqlQuery($"exec TimKiemDauSach_TheoTenDS @TenDauSach", Search_Ten);
                    dtGV_DauSach.DataSource = ListDS.ToList();
                }
                else if (rdbTacGia.Checked == true)
                {
                    var ListDS = qltv.ThongTinDauSaches.SqlQuery($"exec TimKiemDauSach_TheoTacGia @TenTacGia", Search_TG);
                    dtGV_DauSach.DataSource = ListDS.ToList();
                }
                else if (rdbTLDS.Checked == true)
                {
                    var ListDS = qltv.ThongTinDauSaches.SqlQuery($"exec TimKiemDauSach_TheoTheLoaiDS @TenTheLoai", Search_TL);
                    dtGV_DauSach.DataSource = ListDS.ToList();
                }
            }
        }

        private void rdbMaDS_CheckedChanged(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }

        private void rdbTenDS_CheckedChanged(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }

        private void rdbTLDS_CheckedChanged(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }

        private void rdbTacGia_CheckedChanged(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }

        public bool ThemorSua;
        void TrangThaiThemOrSua()
        {
            btThemDs.Enabled = false;
            btSuaDS.Enabled = false;
            btXoaDS.Enabled = false;
            btLuuDS.Enabled = true;
            btHuy.Enabled = true;
            ptbAnhDS.Enabled = true;
            txbTenDS.Enabled = true;
            dtbNXB.Enabled = true;
            txbTenNXB.Enabled = true;
            txbSotrang.Enabled = true;
            txbGiaTien.Enabled = true;
        }
        private void btThemDs_Click(object sender, EventArgs e)
        {
            ThemorSua = true;
            txbMaDS.Text = "";
            txbTenDS.Text = "";
            txbTenNXB.Text = "";
            dtbNXB.Value = DateTime.Now;
            txbSotrang.Text = "";
            txbSoLuong.Text = "0";
            txbGiaTien.Text = "";
            ptbAnhDS.Image = null;
            cbbTacGia.DataSource = null;
            cbbTheLoai.DataSource = null;
            btSuaTG.Visible = false;
            btSuaTL.Visible = false;
            txbMaDS.Enabled = true;
            TrangThaiThemOrSua();
        }

        private void btSuaDS_Click(object sender, EventArgs e)
        {
            ThemorSua = false;
            btSuaTG.Visible = true;
            btSuaTL.Visible = true;
            TrangThaiThemOrSua();
        }

        private void btLuuDS_Click(object sender, EventArgs e)
        {
            using (Model_QuanLi_ThuVien qltv = new Model_QuanLi_ThuVien())
            {
                if (txbMaDS.Text == "") MessageBox.Show("Ban chua dien ma sach");
                else if (txbTenDS.Text == "") MessageBox.Show("Ban chua dien ten dau sach");
                else if (txbTenNXB.Text == "") MessageBox.Show("Ban chua dien ten NXB");
                else if (txbSotrang.Text == "") MessageBox.Show("Ban chua dien so trang");
                else if (txbTenDS.Text == "") MessageBox.Show("Ban chua dien gia tien");
                else if (ptbAnhDS.Image == null) MessageBox.Show("Chua chon anh cho dau sach");
                else
                {
                    SqlParameter[] Param = {
                                    new SqlParameter{ParameterName="MaDauSach",Value=txbMaDS.Text},
                                    new SqlParameter{ParameterName="TenDauSach",Value=txbTenDS.Text},
                                    new SqlParameter{ParameterName="TenNXB",Value=txbTenNXB.Text},
                                    new SqlParameter{ParameterName="NamXuatBan",Value=dtbNXB.Text},
                                    new SqlParameter{ParameterName="SoTrang",Value=txbSotrang.Text},
                                    new SqlParameter{ParameterName="GiaTien",Value=txbGiaTien.Text},
                                    new SqlParameter{ParameterName = "HinhAnh", Value = Byte_HinhAnh }
                                };
                    if (ThemorSua == true)
                    {
                        bool tmt = false;
                        var listMaDS = from kq in qltv.DauSaches select kq.MaDauSach;
                        foreach (var item in listMaDS) { if (txbMaDS.Text == item) tmt = true; }
                        if (tmt == true) MessageBox.Show("Ma dau sach da ton tai!");
                        else
                        {
                            try
                            {
                                qltv.Database.ExecuteSqlCommand($"exec ThemDauSach @MaDauSach,@TenDauSach,@TenNXB,@NamXuatBan,@SoTrang,@GiaTien,@HinhAnh", Param);
                                MessageBox.Show("Them thanh cong dau sach");
                                Load_DauSach();
                                TrangThaiBanDau();
                            }
                            catch (Exception) { MessageBox.Show("Dau sach co van de!"); }
                        }
                    }
                    else
                    {
                        try
                        {
                            qltv.Database.ExecuteSqlCommand($"exec SuaDauSach @MaDauSach,@TenDauSach,@TenNXB,@NamXuatBan,@SoTrang,@GiaTien,@HinhAnh", Param);
                            MessageBox.Show("Sua thanh cong dau sach");
                            Load_DauSach();
                            TrangThaiBanDau();
                        }
                        catch (Exception) { MessageBox.Show("Sua That Bai!"); }
                    }
                }
            }
        }

        private void btSuaTG_Click(object sender, EventArgs e)
        {
            Form formBackround = new Form();
            MaDS = txbMaDS.Text;
            try
            {
                using (Form_ThemTacGia themtg = new Form_ThemTacGia())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .50d;
                    formBackround.BackColor = Color.WhiteSmoke;
                    formBackround.WindowState = FormWindowState.Maximized;
                    themtg.TopMost = true;
                    formBackround.Show();
                    themtg.Location = new Point(1550, 140);
                    themtg.Owner = formBackround;
                    themtg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
            }
            
        }

        private void btSuaTL_Click(object sender, EventArgs e)
        {
            MaDS = txbMaDS.Text;
            Form formBackround = new Form();
            try
            {
                using (Form_ThemTheLoai themtl = new Form_ThemTheLoai())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .50d;
                    formBackround.BackColor = Color.WhiteSmoke;
                    formBackround.WindowState = FormWindowState.Maximized;
                    themtl.TopMost = true;
                    formBackround.Show();
                    themtl.Location = new Point(1550, 140);
                    themtl.Owner = formBackround;
                    themtl.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        private void ptbAnhDS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog OpenFDL = new OpenFileDialog();
            OpenFDL.Filter = OpenFDL.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            OpenFDL.FilterIndex = 1;
            OpenFDL.RestoreDirectory = true;
            if (OpenFDL.ShowDialog() == DialogResult.OK)
            {
                ptbAnhDS.ImageLocation = OpenFDL.FileName;
                textImagePath = OpenFDL.FileName.ToString();
            }
            Byte_HinhAnh = ConvertImageToBytes(textImagePath);
            ptbAnhDS.Image = ByteToImage(Byte_HinhAnh);
        }


        

    }
}

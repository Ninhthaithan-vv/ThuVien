using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QLTVWF.Database;

namespace QLTVWF
{
    public partial class Form_TaiKhoan : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
    );
        public Form_TaiKhoan()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btThongTinNV_Click(object sender, EventArgs e)
        {
            //Pop-up Form
            Form formBackround = new Form();
            try
            {
                using (ThayDoiThongTinNhanVIen ttnv = new ThayDoiThongTinNhanVIen())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .50d;
                    formBackround.BackColor = Color.WhiteSmoke;
                    formBackround.WindowState = FormWindowState.Maximized;
                    formBackround.TopMost = true;
                    ttnv.TopMost = true;
                    formBackround.Show();
                    ttnv.StartPosition = FormStartPosition.CenterScreen;
                    ttnv.Owner = formBackround;
                    ttnv.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
                this.Close();
            }

                
            
        }

        private void btThayDoiMK_Click(object sender, EventArgs e)
        {
            Form formBackround = new Form();
            try
            {
                using (DoiMatKhau dmk = new DoiMatKhau())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .50d;
                    formBackround.BackColor = Color.WhiteSmoke;
                    formBackround.WindowState = FormWindowState.Maximized;
                    formBackround.TopMost = true;
                    dmk.TopMost = true;
                    formBackround.Show();
                    dmk.StartPosition = FormStartPosition.CenterScreen;
                    dmk.Owner = formBackround;
                    dmk.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
                this.Close();
            }
        }

        private void BtDangKyTK_Click(object sender, EventArgs e)
        {
            Form formBackround = new Form();
            try
            {
                using (DangKyNhanVien dknv = new DangKyNhanVien())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .50d;
                    formBackround.BackColor = Color.WhiteSmoke;
                    formBackround.WindowState = FormWindowState.Maximized;
                    formBackround.TopMost = true;
                    dknv.TopMost = true;
                    formBackround.Show();
                    dknv.StartPosition = FormStartPosition.CenterScreen;
                    dknv.Owner = formBackround;
                    dknv.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
                this.Close();
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

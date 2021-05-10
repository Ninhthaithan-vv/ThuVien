using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVWF.Database;

namespace QLTVWF
{
    public partial class DangKyNhanVien : Form
    {
        public DangKyNhanVien()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbXacNhanMK_Validating(object sender, CancelEventArgs e)
        {
            string source = txbMatKhau.Text;
            string destination = txbXacNhanMK.Text;
            if (source.Equals(destination))
            {
                errorProvider1.Clear();
            }
            else
            {
                e.Cancel = true;
                txbXacNhanMK.Focus();
                errorProvider1.SetError(txbXacNhanMK, "Mật khẩu không trùng khớp :( ");
            }
        }

        private void txbSDTNV_Validating(object sender, CancelEventArgs e)
        {
            Regex invalidCharsRegex = new Regex(@"^[0-9]+$");
            string text = txbSDTNV.Text;
            bool result = invalidCharsRegex.IsMatch(text);
            if (result == false)
            {
                e.Cancel = true;
                txbSDTNV.Focus();
                errorProvider1.SetError(txbSDTNV, "Số điện thoại chỉ gồm số !");
            }
            else
            {

                errorProvider1.Clear();

            }
        }

        private void txbTenNV_Validating(object sender, CancelEventArgs e)
        {
            Regex invalidCharsRegex = new Regex(@"^[\D \s ]+$");
            string text = txbTenNV.Text;
            bool result = invalidCharsRegex.IsMatch(text);
            if (result == false)
            {
                e.Cancel = true;
                txbTenNV.Focus();
                errorProvider1.SetError(txbTenNV, "Chỉ gồm các chữ cái !");
            }
            else
            {

                errorProvider1.Clear();

            }
        }

        private void txbTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            Regex invalidCharsRegex = new Regex(@"^[a-zA-Z0-9\s ]+$");
            string text = txbTenDangNhap.Text;
            bool result = invalidCharsRegex.IsMatch(text);
            if (result == false)
            {
                e.Cancel = true;
                txbTenDangNhap.Focus();
                errorProvider1.SetError(txbTenDangNhap, "Chỉ gồm số và chữ cái !");
            }
            else
            {

                errorProvider1.Clear();

            }
        }
    }
}

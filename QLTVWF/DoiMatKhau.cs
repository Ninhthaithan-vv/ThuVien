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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {    
            this.Close();
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

        private void txbXacNhanMK_Validating(object sender, CancelEventArgs e)
        {
            //string source = txbMatKhaumoi.Text;
            //string destination = txbXacNhanMK.Text;
            //if (source.Equals(destination))
            //{
            //    errorProvider1.Clear();
            //}
            //else
            //{
            //    e.Cancel = true;
            //    txbXacNhanMK.Focus();
            //    errorProvider1.SetError(txbXacNhanMK, "Mật khẩu không trùng khớp :( ");
            //}
        }



        private void xemMKcu_Click(object sender, EventArgs e)
        {
     
            if (txbMkCu.UseSystemPasswordChar == true)
            {
                
                txbMkCu.UseSystemPasswordChar = false;
            }
            else txbMkCu.UseSystemPasswordChar = true;
        }

        private void xemMKmoi_Click(object sender, EventArgs e)
        {
            if (txbMkMoi.UseSystemPasswordChar == true)
            {

                txbMkMoi.UseSystemPasswordChar = false;
            }
            else txbMkMoi.UseSystemPasswordChar = true;
        }

        private void xemMKxacnhan_Click(object sender, EventArgs e)
        {
            if (txbNhapLaiMk.UseSystemPasswordChar == true)
            {

                txbNhapLaiMk.UseSystemPasswordChar = false;
            }
            else txbNhapLaiMk.UseSystemPasswordChar = true;
        }

        private void nhap_Click(object sender, EventArgs e)
        {
            if (txbMkCu.UseSystemPasswordChar == true) txbMkCu.UseSystemPasswordChar = false;
            else txbMkCu.UseSystemPasswordChar = true;
        }
    }
}

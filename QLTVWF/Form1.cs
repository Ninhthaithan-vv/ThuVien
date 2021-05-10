using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using QLTVWF.Database;

namespace QLTVWF
{
    public partial class Menu : Form
    {
        //Curve Border
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

        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
            //this.WindowState = FormWindowState.Maximized;
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 58);
            panelMenu.Controls.Add(leftBorderButton);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;

        }
        private void MTA_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButton.Visible = false;
        }


        #region Methods
        private void ActivateButton(object senderbutton)
        {
            if (senderbutton != null)
            {
                DisableButton();
                currentButton = (IconButton)senderbutton;
                currentButton.BackColor = Color.FromArgb(42, 40, 60);
                currentButton.IconColor = Color.FromArgb(115, 249, 181);
                currentButton.ImageAlign = ContentAlignment.MiddleCenter;
                //Left border button
                leftBorderButton.BackColor = Color.FromArgb(67, 192, 121);
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
                ////Current Child Form Icon
                //currentButton.IconChar = currentButton.IconChar;
                //currentButton.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(67, 192, 121);
                currentButton.IconColor = Color.WhiteSmoke;
                currentButton.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }
        #endregion Methods

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            panelDesktop.ForeColor = childForm.ForeColor;
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }


        private void iconBt_DocGia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panelDesktop.Controls.Clear();
            QuanLyDocGia quanLiDocGia = new QuanLyDocGia();
            quanLiDocGia.TopLevel = false;

            panelDesktop.Controls.Add(quanLiDocGia);
            quanLiDocGia.Dock = DockStyle.Fill;
            //Backround_Panel.Tag = quanlycuonsach;
            //quanlycuonsach.BringToFront();
            quanLiDocGia.Show();
        }

        private void iconBt_Sach_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //ActivateButton(sender);
            //OpenChildForm(new QuanLyDauSach());
            panelDesktop.Controls.Clear();
            Form quanLydausach = new QuanLyDauSach();
            quanLydausach.TopLevel = false;

            panelDesktop.Controls.Add(quanLydausach);
            quanLydausach.Dock = DockStyle.Fill;
            //Backround_Panel.Tag = quanlycuonsach;
            //quanlycuonsach.BringToFront();
            quanLydausach.Show();
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new MuonSach());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new TraSach());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        #region Move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ScreenMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        #endregion Move

        

        private void iconBt_TaiKhoan_Click(object sender, EventArgs e)
        {
            

        }

        private void accountChip_Click(object sender, EventArgs e)
        {
            //Pop-up Form
            Form formBackround = new Form();
            try
            {
                using(Form_TaiKhoan tk = new Form_TaiKhoan())
                {
                    formBackround.StartPosition = FormStartPosition.Manual;
                    formBackround.FormBorderStyle = FormBorderStyle.None;
                    formBackround.Opacity = .0d;
                    formBackround.BackColor = Color.FromArgb(115, 249, 181);
                    formBackround.WindowState = FormWindowState.Maximized;
                    formBackround.TopMost = true;
                    formBackround.Show();
                    tk.Location = new Point(1550, 140);
                    tk.Owner = formBackround;
                    tk.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackround.Dispose();
            }
        }
    }
}

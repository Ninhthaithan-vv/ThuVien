
namespace QLTVWF
{
    partial class Form_ThemTheLoai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemTheLoai));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txbViTriVaiTro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbTenTheLoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaTheLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGV_TheLoai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btThoat = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_TheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.txbViTriVaiTro);
            this.panel1.Controls.Add(this.txbTenTheLoai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbMaTheLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(602, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 271);
            this.panel1.TabIndex = 1;
            // 
            // btXoa
            // 
            this.btXoa.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btXoa.BorderRadius = 18;
            this.btXoa.BorderThickness = 1;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.Enabled = false;
            this.btXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(234)))), ((int)(((byte)(31)))));
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Location = new System.Drawing.Point(243, 214);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(81, 39);
            this.btXoa.TabIndex = 36;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btThem.BorderRadius = 18;
            this.btThem.BorderThickness = 1;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.Enabled = false;
            this.btThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(234)))), ((int)(((byte)(31)))));
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Location = new System.Drawing.Point(137, 214);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(81, 39);
            this.btThem.TabIndex = 35;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btLuu.BorderRadius = 18;
            this.btLuu.BorderThickness = 1;
            this.btLuu.CheckedState.Parent = this.btLuu;
            this.btLuu.CustomImages.Parent = this.btLuu;
            this.btLuu.Enabled = false;
            this.btLuu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(234)))), ((int)(((byte)(31)))));
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btLuu.HoverState.Parent = this.btLuu;
            this.btLuu.Location = new System.Drawing.Point(26, 214);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.ShadowDecoration.Parent = this.btLuu;
            this.btLuu.Size = new System.Drawing.Size(81, 39);
            this.btLuu.TabIndex = 34;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // txbViTriVaiTro
            // 
            this.txbViTriVaiTro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbViTriVaiTro.Enabled = false;
            this.txbViTriVaiTro.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbViTriVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbViTriVaiTro.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txbViTriVaiTro.HintText = "Vị trí vai trò";
            this.txbViTriVaiTro.isPassword = false;
            this.txbViTriVaiTro.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineIdleColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineThickness = 1;
            this.txbViTriVaiTro.Location = new System.Drawing.Point(143, 162);
            this.txbViTriVaiTro.Margin = new System.Windows.Forms.Padding(4);
            this.txbViTriVaiTro.Name = "txbViTriVaiTro";
            this.txbViTriVaiTro.Size = new System.Drawing.Size(194, 35);
            this.txbViTriVaiTro.TabIndex = 33;
            this.txbViTriVaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbTenTheLoai
            // 
            this.txbTenTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenTheLoai.Enabled = false;
            this.txbTenTheLoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbTenTheLoai.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txbTenTheLoai.HintText = "Tên thể loại";
            this.txbTenTheLoai.isPassword = false;
            this.txbTenTheLoai.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txbTenTheLoai.LineIdleColor = System.Drawing.Color.Transparent;
            this.txbTenTheLoai.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txbTenTheLoai.LineThickness = 1;
            this.txbTenTheLoai.Location = new System.Drawing.Point(143, 104);
            this.txbTenTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenTheLoai.Name = "txbTenTheLoai";
            this.txbTenTheLoai.Size = new System.Drawing.Size(194, 35);
            this.txbTenTheLoai.TabIndex = 32;
            this.txbTenTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vị trí vai trò:";
            // 
            // cbbMaTheLoai
            // 
            this.cbbMaTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.cbbMaTheLoai.Enabled = false;
            this.cbbMaTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMaTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.cbbMaTheLoai.FormattingEnabled = true;
            this.cbbMaTheLoai.Location = new System.Drawing.Point(139, 45);
            this.cbbMaTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaTheLoai.Name = "cbbMaTheLoai";
            this.cbbMaTheLoai.Size = new System.Drawing.Size(191, 28);
            this.cbbMaTheLoai.TabIndex = 3;
            this.cbbMaTheLoai.TextChanged += new System.EventHandler(this.cbbMaTheLoai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtGV_TheLoai);
            this.panel2.Location = new System.Drawing.Point(14, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 271);
            this.panel2.TabIndex = 2;
            // 
            // dtGV_TheLoai
            // 
            this.dtGV_TheLoai.AllowUserToAddRows = false;
            this.dtGV_TheLoai.AllowUserToDeleteRows = false;
            this.dtGV_TheLoai.AllowUserToResizeColumns = false;
            this.dtGV_TheLoai.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGV_TheLoai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_TheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_TheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGV_TheLoai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGV_TheLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_TheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGV_TheLoai.ColumnHeadersHeight = 30;
            this.dtGV_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_TheLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGV_TheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGV_TheLoai.EnableHeadersVisualStyles = false;
            this.dtGV_TheLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TheLoai.Location = new System.Drawing.Point(3, 28);
            this.dtGV_TheLoai.Name = "dtGV_TheLoai";
            this.dtGV_TheLoai.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_TheLoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGV_TheLoai.RowHeadersVisible = false;
            this.dtGV_TheLoai.RowHeadersWidth = 62;
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TheLoai.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TheLoai.RowTemplate.Height = 28;
            this.dtGV_TheLoai.RowTemplate.ReadOnly = true;
            this.dtGV_TheLoai.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGV_TheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_TheLoai.Size = new System.Drawing.Size(563, 233);
            this.dtGV_TheLoai.TabIndex = 11;
            this.dtGV_TheLoai.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtGV_TheLoai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGV_TheLoai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGV_TheLoai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGV_TheLoai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGV_TheLoai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGV_TheLoai.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TheLoai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_TheLoai.ThemeStyle.HeaderStyle.Height = 30;
            this.dtGV_TheLoai.ThemeStyle.ReadOnly = true;
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.Height = 28;
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGV_TheLoai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGV_TheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_TheLoai_CellClick);
            // 
            // btThoat
            // 
            this.btThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btThoat.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btThoat.IconColor = System.Drawing.Color.Red;
            this.btThoat.IconSize = 50;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btThoat.Location = new System.Drawing.Point(893, -5);
            this.btThoat.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btThoat.Name = "btThoat";
            this.btThoat.Rotation = 0D;
            this.btThoat.Size = new System.Drawing.Size(70, 54);
            this.btThoat.TabIndex = 9;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(73, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thông tin tác giả";
            // 
            // Form_ThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(973, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_ThemTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemTheLoai";
            this.Load += new System.EventHandler(this.Form_ThemTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_TheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbViTriVaiTro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbTenTheLoai;
        private Guna.UI2.WinForms.Guna2GradientButton btLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btThem;
        private Guna.UI2.WinForms.Guna2GradientButton btXoa;
        private FontAwesome.Sharp.IconButton btThoat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dtGV_TheLoai;
        private System.Windows.Forms.Label label5;
    }
}
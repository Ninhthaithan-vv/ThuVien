
namespace QLTVWF
{
    partial class Form_ThemTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemTacGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGV_TacGia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenTG = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbViTriVaiTro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dTP_NgaySinhTG = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbbMaTG = new System.Windows.Forms.ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btThoat = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_TacGia)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtGV_TacGia);
            this.panel1.Location = new System.Drawing.Point(9, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 187);
            this.panel1.TabIndex = 0;
            // 
            // dtGV_TacGia
            // 
            this.dtGV_TacGia.AllowUserToAddRows = false;
            this.dtGV_TacGia.AllowUserToDeleteRows = false;
            this.dtGV_TacGia.AllowUserToResizeColumns = false;
            this.dtGV_TacGia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGV_TacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_TacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_TacGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGV_TacGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGV_TacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_TacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGV_TacGia.ColumnHeadersHeight = 30;
            this.dtGV_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_TacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGV_TacGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGV_TacGia.EnableHeadersVisualStyles = false;
            this.dtGV_TacGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TacGia.Location = new System.Drawing.Point(5, 18);
            this.dtGV_TacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGV_TacGia.Name = "dtGV_TacGia";
            this.dtGV_TacGia.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_TacGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGV_TacGia.RowHeadersVisible = false;
            this.dtGV_TacGia.RowHeadersWidth = 62;
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TacGia.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TacGia.RowTemplate.Height = 28;
            this.dtGV_TacGia.RowTemplate.ReadOnly = true;
            this.dtGV_TacGia.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGV_TacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_TacGia.Size = new System.Drawing.Size(353, 165);
            this.dtGV_TacGia.TabIndex = 10;
            this.dtGV_TacGia.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtGV_TacGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGV_TacGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGV_TacGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGV_TacGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGV_TacGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGV_TacGia.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.dtGV_TacGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(242)))), ((int)(((byte)(117)))));
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(254)))), ((int)(((byte)(251)))));
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_TacGia.ThemeStyle.HeaderStyle.Height = 30;
            this.dtGV_TacGia.ThemeStyle.ReadOnly = true;
            this.dtGV_TacGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGV_TacGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGV_TacGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGV_TacGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            this.dtGV_TacGia.ThemeStyle.RowsStyle.Height = 28;
            this.dtGV_TacGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGV_TacGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGV_TacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_TacGia_CellClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(655, 294);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 222);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(34, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thông tin tác giả";
            // 
            // txbTenTG
            // 
            this.txbTenTG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenTG.Enabled = false;
            this.txbTenTG.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbTenTG.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbTenTG.HintText = "Tên tác giả";
            this.txbTenTG.isPassword = false;
            this.txbTenTG.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txbTenTG.LineIdleColor = System.Drawing.Color.Transparent;
            this.txbTenTG.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txbTenTG.LineThickness = 1;
            this.txbTenTG.Location = new System.Drawing.Point(113, 49);
            this.txbTenTG.Name = "txbTenTG";
            this.txbTenTG.Size = new System.Drawing.Size(129, 23);
            this.txbTenTG.TabIndex = 31;
            this.txbTenTG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vị trí vai trò:";
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
            this.btXoa.Location = new System.Drawing.Point(182, 149);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(63, 25);
            this.btXoa.TabIndex = 28;
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
            this.btThem.Location = new System.Drawing.Point(103, 149);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(63, 25);
            this.btThem.TabIndex = 29;
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
            this.btLuu.Location = new System.Drawing.Point(17, 149);
            this.btLuu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btLuu.Name = "btLuu";
            this.btLuu.ShadowDecoration.Parent = this.btLuu;
            this.btLuu.Size = new System.Drawing.Size(63, 25);
            this.btLuu.TabIndex = 30;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txbViTriVaiTro);
            this.panel3.Controls.Add(this.dTP_NgaySinhTG);
            this.panel3.Controls.Add(this.cbbMaTG);
            this.panel3.Controls.Add(this.txbTenTG);
            this.panel3.Controls.Add(this.btLuu);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(389, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 187);
            this.panel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(113, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 3);
            this.label6.TabIndex = 9;
            // 
            // txbViTriVaiTro
            // 
            this.txbViTriVaiTro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbViTriVaiTro.Enabled = false;
            this.txbViTriVaiTro.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbViTriVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbViTriVaiTro.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.txbViTriVaiTro.HintText = "Vị trí vai trò";
            this.txbViTriVaiTro.isPassword = false;
            this.txbViTriVaiTro.LineFocusedColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineIdleColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.txbViTriVaiTro.LineThickness = 1;
            this.txbViTriVaiTro.Location = new System.Drawing.Point(113, 112);
            this.txbViTriVaiTro.Name = "txbViTriVaiTro";
            this.txbViTriVaiTro.Size = new System.Drawing.Size(129, 23);
            this.txbViTriVaiTro.TabIndex = 34;
            this.txbViTriVaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dTP_NgaySinhTG
            // 
            this.dTP_NgaySinhTG.CheckedState.Parent = this.dTP_NgaySinhTG;
            this.dTP_NgaySinhTG.Enabled = false;
            this.dTP_NgaySinhTG.FillColor = System.Drawing.Color.Empty;
            this.dTP_NgaySinhTG.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_NgaySinhTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.dTP_NgaySinhTG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgaySinhTG.HoverState.Parent = this.dTP_NgaySinhTG;
            this.dTP_NgaySinhTG.Location = new System.Drawing.Point(113, 84);
            this.dTP_NgaySinhTG.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dTP_NgaySinhTG.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dTP_NgaySinhTG.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dTP_NgaySinhTG.Name = "dTP_NgaySinhTG";
            this.dTP_NgaySinhTG.ShadowDecoration.Parent = this.dTP_NgaySinhTG;
            this.dTP_NgaySinhTG.Size = new System.Drawing.Size(129, 16);
            this.dTP_NgaySinhTG.TabIndex = 33;
            this.dTP_NgaySinhTG.Value = new System.DateTime(2021, 4, 29, 1, 35, 3, 737);
            // 
            // cbbMaTG
            // 
            this.cbbMaTG.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbMaTG.Enabled = false;
            this.cbbMaTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMaTG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(237)))), ((int)(((byte)(15)))));
            this.cbbMaTG.Location = new System.Drawing.Point(113, 19);
            this.cbbMaTG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbMaTG.Name = "cbbMaTG";
            this.cbbMaTG.Size = new System.Drawing.Size(130, 21);
            this.cbbMaTG.TabIndex = 32;
            this.cbbMaTG.TextChanged += new System.EventHandler(this.cbbMaTG_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.AutoSize = true;
            this.btThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btThoat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btThoat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(49)))), ((int)(((byte)(1)))));
            this.btThoat.IconSize = 30;
            this.btThoat.Location = new System.Drawing.Point(610, 7);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btThoat.Name = "btThoat";
            this.btThoat.Rotation = 0D;
            this.btThoat.Size = new System.Drawing.Size(36, 36);
            this.btThoat.TabIndex = 4;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form_ThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(655, 248);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form_ThemTacGia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThemTacGia";
            this.Load += new System.EventHandler(this.Form_ThemTacGia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_TacGia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbTenTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btThem;
        private Guna.UI2.WinForms.Guna2GradientButton btLuu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbMaTG;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbViTriVaiTro;
        private Guna.UI2.WinForms.Guna2DateTimePicker dTP_NgaySinhTG;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dtGV_TacGia;
        private FontAwesome.Sharp.IconButton btThoat;
    }
}
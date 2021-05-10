using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVWF.Database;
namespace QLTVWF
{
    public partial class RePortViPham : Form
    {
        public RePortViPham()
        {
            InitializeComponent();
        }

        private void RePortViPham_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        public RePortViPham(string lydo, int sotien, string MaDG)
        {
            InitializeComponent();
            // đặt chế độ hiển thị ở Local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLTVWF.XuLyViPham.rdlc";
            // chế độ xem report 
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            //// import dữ liệu tên độc giả và đơn vị 

            Model_QuanLi_ThuVien MtV1 = new Model_QuanLi_ThuVien();
            SqlParameter idParam = new SqlParameter { ParameterName = "MaDocGia", Value = MaDG };
            var lstMuonTra = MtV1.ThongTinDocGias.SqlQuery("ThongTinCaNhan @MaDocGia", idParam).ToList();
            /// fill data vào trong báo cáo
            Microsoft.Reporting.WinForms.ReportParameter[] rParrams = new Microsoft.Reporting.WinForms.ReportParameter[]
            { new Microsoft.Reporting.WinForms.ReportParameter("HoTen", lstMuonTra[0].TenDocGia.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("DonVi",lstMuonTra[0].DonVi.ToString()),
              new Microsoft.Reporting.WinForms.ReportParameter("LyDo", lydo),
               new Microsoft.Reporting.WinForms.ReportParameter("SoTien", sotien.ToString()) };
            reportViewer1.LocalReport.SetParameters(rParrams);
            reportViewer1.RefreshReport();
        }
    }
}

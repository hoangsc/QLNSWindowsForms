using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNSWindowsForms.DataBindingHC;
using QLNSWindowsForms.Repository;
using System.IO;

namespace QLNSWindowsForms.View
{
    public partial class MainViewFull : DevExpress.XtraEditors.XtraForm
    {
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();
        public MainViewFull()
        {
            InitializeComponent();
            LoadData();
            gridView1.ShowFindPanel();
        }

        private async void LoadData()
        {
            var datetimenow = DateTime.Now;
            var datetimeplus = datetimenow.AddMonths(3);
            gridControlNhanVien.DataSource =  await _nhanVienRepository.GetList();
            if (MainView.filter_hopdong == 0)
            {
                gridView1.ActiveFilterString = $"([HopDong.NgayKetThuc] < #{DateTime.Now}#)";
                
            }
            else
            {
                
                gridView1.ActiveFilterString = $"([HopDong.NgayKetThuc] > #{DateTime.Now}# && [HopDong.NgayKetThuc] <= #{datetimeplus}# )";
            }
        }

        private void buttonExExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel(.xlsx) | *.xls;*.xlsx | Pdf File(.pdf) | *.pdf |Html File (.html)|*.html |Word(.docx) | *.docx";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dialog.FileName);
                filePath = dialog.FileName;
                switch (extension)
                {
                    case ".xls":
   
                        gridView1.ExportToXls(filePath);
                        XtraMessageBox.Show("Xuất file Excel thành công!");
                        break;
                    case ".xlsx":
                        gridView1.ExportToXlsx(filePath);
                        XtraMessageBox.Show("Xuất file Excel thành công!");
                        break;
                    case ".docx":
                        gridView1.ExportToDocx(filePath);
                        XtraMessageBox.Show("Xuất file Docx thành công!");
                        break;
                    case ".pdf":
                        gridView1.ExportToPdf(filePath);
                        XtraMessageBox.Show("Xuất file PDF thành công!");
                        break;
                    case ".html":
                        gridView1.ExportToHtml(filePath);
                        XtraMessageBox.Show("Xuất file HTML thành công!");
                        break;
                    default:
                        XtraMessageBox.Show("File không đúng định dạng!");
                        break;
                }
            }
        }
    }
}
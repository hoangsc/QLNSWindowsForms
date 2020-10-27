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
using QLNSWindowsForms.Repository;
using QLNSWindowsForms.Models;

namespace QLNSWindowsForms.View
{
    public partial class DepartmenAddForm : DevExpress.XtraEditors.XtraForm
    {
        DonViRepository _donViRepository = new DonViRepository();
        HocViRepository _hocViRepository = new HocViRepository();
        HopDongRepository _hopDongRepository = new HopDongRepository();
        NgachRepository _ngachRepository = new NgachRepository();
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();
        public DepartmenAddForm()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                HocVi hocvi = new HocVi();
                hocvi.HocViId = 1;
                hocvi.TenHocVi = TenHocViTextEdit.Text;

                DialogResult dr = XtraMessageBox.Show($"Bạn có chắc chắn muốn thêm học vị '{TenHocViTextEdit.Text} không?'", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        _hocViRepository.Add(hocvi);
                        XtraMessageBox.Show("Thêm học vị thành công");
                        this.Close();
                        break;
                    case DialogResult.No:
                        XtraMessageBox.Show("Huỷ thêm học vị");
                        break;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show($"Thêm học vị thất bại.... Lỗi {ex.ToString()}", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class DegreeAddForm : DevExpress.XtraEditors.XtraForm
    {
        DonViRepository _donViRepository = new DonViRepository();
        HocViRepository _hocViRepository = new HocViRepository();
        HopDongRepository _hopDongRepository = new HopDongRepository();
        NgachRepository _ngachRepository = new NgachRepository();
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();

        public DegreeAddForm()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                DonVi donVi = new DonVi();
                donVi.DonViId = 1;
                donVi.TenDonVi = TenDonViTextEdit.Text;

                DialogResult dr = XtraMessageBox.Show($"Bạn có chắc chắn muốn thêm đơn vị '{TenDonViTextEdit.Text} không?'", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        _donViRepository.Add(donVi);
                        XtraMessageBox.Show("Thêm đơn vị thành công");
                        this.Close();
                        break;
                    case DialogResult.No:
                        XtraMessageBox.Show("Huỷ thêm học vị");
                        break;
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show($"Thêm đơn vị thất bại.... Lỗi {ex.ToString()}", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
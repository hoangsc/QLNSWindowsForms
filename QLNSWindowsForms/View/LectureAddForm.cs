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
using QLNSWindowsForms.Models;
using QLNSWindowsForms.Repository;

namespace QLNSWindowsForms.View
{
    public partial class LectureAddForm : DevExpress.XtraEditors.XtraForm
    {
        DonViRepository _donViRepository = new DonViRepository();
        HocViRepository _hocViRepository = new HocViRepository();
        HopDongRepository _hopDongRepository = new HopDongRepository();
        NgachRepository _ngachRepository = new NgachRepository();
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();

        public LectureAddForm()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            comboBoxDonVi.DataSource = await _donViRepository.GetList();
            comboBoxHocVi.DataSource = await _hocViRepository.GetList();
            comboBoxNgach.DataSource = await _ngachRepository.GetList();
        }

        private async void btnAddLecture_Click(object sender, EventArgs e)
        {
            try
            {
                var hopDong = new HopDong()
                {
                    NgayKi = NgayKiDateEdit.DateTime,
                    NgayKetThuc = NgayKetThucDateEdit.DateTime
                };
                var newHopDong = await _hopDongRepository.Add(hopDong);

                var nhanVien = new NhanVien()
                {
                    HoTen = HoTenTextEdit.Text,
                    NgaySinh = NgaySinhDateEdit.DateTime,
                    GioiTinh = Boolean.Parse(GioiTinhCheckEdit.Properties.Items[GioiTinhCheckEdit.SelectedIndex].Value.ToString()),

                    DanToc = DanTocTextEdit.Text,
                    TonGiao = TonGiaoTextEdit.Text,
                    SoDienThoai = Convert.ToInt32(SoDienThoaiTextEdit.Text),
                    Email = EmailTextEdit.Text,
                    DiaChi = DiaChiTextEdit.Text,
                    SoCMND = Convert.ToInt32(SoCMNDTextEdit.Text),
                    Anh = AnhTextEdit.Text,
                    DangVien = Boolean.Parse(DangVienCheckEdit.OldEditValue.ToString()),
                    HocViId = Convert.ToInt32(comboBoxHocVi.SelectedValue.ToString()),
                    DonViId = Convert.ToInt32(comboBoxDonVi.SelectedValue.ToString()),
                    HopDongId = newHopDong.HopDongId,
                    NgachId = Convert.ToInt32(comboBoxNgach.SelectedValue.ToString())
                };
                _nhanVienRepository.Add(nhanVien);
                XtraMessageBox.Show("Thêm nhân viên thành công");
            }
            catch(Exception ex)
            {

                XtraMessageBox.Show($"Thêm nhân viên thất bại.... Lỗi {ex.ToString()}", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelLecture_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
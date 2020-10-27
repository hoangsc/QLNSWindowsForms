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
using DevExpress.XtraBars;

namespace QLNSWindowsForms.View
{
    public partial class LectureEditForm : DevExpress.XtraEditors.XtraForm
    {
        DonViRepository _donViRepository = new DonViRepository();
        HocViRepository _hocViRepository = new HocViRepository();
        HopDongRepository _hopDongRepository = new HopDongRepository();
        NgachRepository _ngachRepository = new NgachRepository();
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();
        MainView mv = new MainView();

        public LectureEditForm()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            DonViIdLookUpEdit.Properties.DataSource = await _donViRepository.GetList();
            HocViIdLookUpEdit.Properties.DataSource = await _hocViRepository.GetList();
            NgachIdLookUpEdit.Properties.DataSource = await _ngachRepository.GetList();
            HopDongIdLookUpEdit.Properties.DataSource = await _hopDongRepository.GetList();
            dataLayoutControlLectureEdit.DataSource = await _nhanVienRepository.Get(MainView.NhanVienIdRowSelected);
        }

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            object donVi = DonViIdLookUpEdit.GetSelectedDataRow();
            object hocVi = HocViIdLookUpEdit.GetSelectedDataRow();
            object ngach = NgachIdLookUpEdit.GetSelectedDataRow();
            object hopDong = HopDongIdLookUpEdit.GetSelectedDataRow();
            try
            {
                HopDong newHopDong = new HopDong()
                {
                    NgayKi = HopDongNgayKiDateEdit.DateTime,
                    NgayKetThuc = HopDongNgayKetThucDateEdit.DateTime
                };
                _hopDongRepository.Edit(newHopDong, (hopDong as HopDong).HopDongId);

                var nhanVien = new NhanVien()
                {
                    HoTen = HoTenTextEdit.Text,
                    NgaySinh = NgaySinhDateEdit.DateTime,
                    GioiTinh = Boolean.Parse(GioiTinhRadioGroup.Properties.Items[GioiTinhRadioGroup.SelectedIndex].Value.ToString()),
                    DanToc = DanTocTextEdit.Text,
                    TonGiao = TonGiaoTextEdit.Text,
                    SoDienThoai = Convert.ToInt32(SoDienThoaiTextEdit.Text),
                    Email = EmailTextEdit.Text,
                    DiaChi = DiaChiTextEdit.Text,
                    SoCMND = Convert.ToInt32(SoCMNDTextEdit.Text),
                    Anh = AnhTextEdit.Text,
                    DangVien = Boolean.Parse(DangVienCheckEdit.OldEditValue.ToString()),
                    HocViId = (hocVi as HocVi).HocViId,
                    DonViId = (donVi as DonVi).DonViId,
                    HopDongId = (hopDong as HopDong).HopDongId,
                    NgachId = (ngach as Ngach).NgachId
                };
                _nhanVienRepository.Edit(nhanVien, MainView.NhanVienIdRowSelected);


                XtraMessageBox.Show("Sửa nhân viên thành công");
                this.Close();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show($"Sửa nhân viên thất bại.... Lỗi {ex.ToString()}", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
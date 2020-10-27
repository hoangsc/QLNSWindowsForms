using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLNSWindowsForms.Models;
using QLNSWindowsForms.Repository;
using QLNSWindowsForms.DataBindingHC;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace QLNSWindowsForms.View
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();
        DonViRepository _donViRepository = new DonViRepository();
        public static int NhanVienIdRowSelected;
        public static int filter_hopdong;
        private DataBindingCenter _dataBindingCenter;
        int numrow;
        public MainView()
        {
            InitializeComponent();
            _dataBindingCenter = new DataBindingCenter(nhanVienBindingSource, donViBindingSource, hocViBindingSource, ngachBindingSource, this);
            nhanVienGridControl.Click += (e, s) => _dataBindingCenter.ReLoad();
            nhanVienBindingSource.DataMemberChanged += (e, s) => _dataBindingCenter.ReLoad();
            LoadData();

        }

        public async void LoadData()
        {
            var listNV = await _nhanVienRepository.GetList();
            _dataBindingCenter.ReLoad();
            nhanVienGridControl.DataSource = dataLayoutControl1.DataSource;

           // var listNV = nhanVienBindingSource.List as List<NhanVien>;
        }

        public void barButtonLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            
        }
        private void barButtonNewLecture_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form newform = new View.LectureAddForm();
            newform.Show();
        }

        private void barButtonDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form newform = new View.LectureEditForm();
            newform.Show();
        }

        private void barButtonDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            _nhanVienRepository.Delete(NhanVienIdRowSelected);
            gridView1.DeleteRow(numrow);
            XtraMessageBox.Show("Xoá nhân viên thành công");
            barButtonLoad_ItemClick( sender, e);
        }
        AccordionControlElement AddItem(AccordionControlElement group, string txt)//add element
        {
            AccordionControlElement item = new AccordionControlElement() { Text = txt, Style = ElementStyle.Item };
            AccordionControlSeparator separator = new AccordionControlSeparator();
            group.Elements.Add(item);
            group.Elements.Add(separator);    
            return item;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AddItem(accordionControlElementHopDong, "Hoang Chu");
            var listNV = nhanVienBindingSource.List as List<NhanVien>;
            var datetimenow = DateTime.Now;
            var datetimeplus = datetimenow.AddMonths(3);
            bool flag = false;

            foreach (var a in listNV)
            {
                int compare = DateTime.Compare(datetimenow, a.HopDong.NgayKetThuc);
                if (a.HopDong.NgayKetThuc >= DateTime.Now && a.HopDong.NgayKetThuc <= datetimeplus)
                {
                    flag = true;
                }

            }
            if(flag == true)
            {
                MessageBox.Show("Có nhân viên hết hạn hợp đồng. Vui lòng kiểm tra");
            }
            else
            {
                MessageBox.Show("Không có nhân viên sắp hết hạn hợp đồng!");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            _nhanVienRepository.Delete(NhanVienIdRowSelected);
            XtraMessageBox.Show("Xoá nhân viên thành công");
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            object datarow = gridView1.GetRowCellValue(numrow, "NhanVienId");
            NhanVienIdRowSelected = Convert.ToInt32(datarow);
        }

        private void accordionControlCNPM_ClickAsync(object sender, EventArgs e)//test
        {
            gridView1.ActiveFilterString= "([DonViId] = 1)";
        }

        private void accordionControlHTTT_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([DonViId] = 2)";
        }

        private void accordionControlMATTT_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([DonViId] = 3)";
        }

        private void accordionControlKHMTCN_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([DonViId] = 4)";
        }

        private void accordionControlElementThacSi_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([HocViId] = 2)";
        }

        private void accordionControlElementTienSi_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([HocViId] = 1)";
        }

        private void accordionControlElementTienSiKH_Click(object sender, EventArgs e)
        {
            gridView1.ActiveFilterString = "([HocViId] = 3)";
        }

        private void accordionControlElementHD1Thang_Click(object sender, EventArgs e)
        {
            MainViewFull mainViewFull = new MainViewFull();
            filter_hopdong = 1;
            mainViewFull.Show();
        }
        private void accordionControlElementHDHetHan_Click(object sender, EventArgs e)
        {
            MainViewFull mainViewFull = new MainViewFull();
            filter_hopdong = 0;
            mainViewFull.Show();
        }

        private void list_filter_donvi(int id)
        {
            var listNV = nhanVienBindingSource.List as List<NhanVien>;
            var listSelected = new List<NhanVien>();

            foreach (var a in listNV)
            {
                if (a.DonViId == id)
                {
                    listSelected.Add(a);

                }
            }
            nhanVienGridControl.DataSource = listSelected.ToList();
            dataLayoutControl1.DataSource = nhanVienGridControl.DataSource;
        }
        private void listfilter_hocvi(int id)
        {
            var listNV = nhanVienBindingSource.List as List<NhanVien>;
            var listSelected = new List<NhanVien>();

            foreach (var a in listNV)
            {
                if (a.HocViId == id)
                {
                    listSelected.Add(a);

                }
            }
            nhanVienGridControl.DataSource = listSelected.ToList();
            dataLayoutControl1.DataSource = nhanVienGridControl.DataSource;
        }
        private void listfilter_hopdong(int id)
        {
            var listNV = nhanVienBindingSource.List as List<NhanVien>;
            var listSelected = new List<NhanVien>();

            var datetimenow = DateTime.Now;
            if(id == 0)
            {
                foreach (var a in listNV)
                {
                    if (a.HopDong.NgayKetThuc <= datetimenow)
                    {
                        listSelected.Add(a);
                    }
                }
            }
            else
            {
                var datetimeplus =datetimenow.AddMonths(3);
                foreach (var a in listNV)
                {
                    int compare = DateTime.Compare(datetimenow, a.HopDong.NgayKetThuc);
                    if (a.HopDong.NgayKetThuc >= DateTime.Now && a.HopDong.NgayKetThuc <= datetimeplus)
                    {
                        listSelected.Add(a);
                    }
                }
            }
            nhanVienGridControl.DataSource = listSelected.ToList();
            dataLayoutControl1.DataSource = nhanVienGridControl.DataSource;
            
        }

        private void barButtonViewAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainViewFull mainViewFull = new MainViewFull();
            mainViewFull.Show();
        }

        private void barButtonItemFilter_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView1.ShowFindPanel();
        }

        private void barButtonItemChart_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnalysisChartForm analysisChartForm = new AnalysisChartForm();
            analysisChartForm.Show();
        }

        private void barButtonItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        {

            DialogResult dr = XtraMessageBox.Show($"Tác giả: Hoàng Chu \n Liên hệ với tôi?" , "Thông tin liên hệ ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (dr)
            {
                case DialogResult.Yes:
                    System.Diagnostics.Process.Start("https://www.facebook.com/hoangm4v");
                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void barButtonItemNewDegree_ItemClick(object sender, ItemClickEventArgs e)
        {
            DegreeAddForm degreeAddForm = new DegreeAddForm();
            degreeAddForm.Show();
        }

        private void barButtonItemNewDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            DepartmenAddForm departmenAddForm = new DepartmenAddForm();
            departmenAddForm.Show();
        }

        private void GioiTinhRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
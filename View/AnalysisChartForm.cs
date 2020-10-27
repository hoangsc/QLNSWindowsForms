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

namespace QLNSWindowsForms.View
{
    public partial class AnalysisChartForm : DevExpress.XtraEditors.XtraForm
    {
        public string CNPM, HTTT, MMT, KHMT;
        public int sumCNPM = 0;
       public int sumHTTT = 0;
        public int sumMMT = 0;
        public int sumKHMT = 0;
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public AnalysisChartForm()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //chartPie.Titles.Add("Design by Hoang Chu");
            chartPie.Series["s1"].IsValueShownAsLabel = true;
            chartPie.Series["s1"].Points.AddXY($"BM {CNPM}", $"{sumCNPM}");
            chartPie.Series["s1"].Points.AddXY($"BM {HTTT}", $"{sumHTTT}");
            chartPie.Series["s1"].Points.AddXY($"BM {MMT}", $"{sumMMT}");
            chartPie.Series["s1"].Points.AddXY($"BM {KHMT}", $"{sumKHMT}");
        }

        private async void LoadData()
        {
            var listNV = await _nhanVienRepository.GetList();
            foreach(var a in listNV)
            {
                if(a.DonViId == 1)
                {
                    sumCNPM++;
                    CNPM = a.DonVi.TenDonVi;
                }
                if(a.DonViId == 2)
                {
                    sumHTTT++;
                    HTTT = a.DonVi.TenDonVi;
                }
                if (a.DonViId == 3)
                {
                    sumMMT++;
                    MMT = a.DonVi.TenDonVi;
                }
                if (a.DonViId == 4)
                {
                    sumKHMT++;
                    KHMT = a.DonVi.TenDonVi;
                }
            }
        }
    }
}
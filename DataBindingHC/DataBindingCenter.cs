using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNSWindowsForms.Repository;
using QLNSWindowsForms.Models;
using System.Windows.Forms;
using QLNSWindowsForms.View;

namespace QLNSWindowsForms.DataBindingHC
{
    public class DataBindingCenter
    {
        NhanVienRepository _nhanVienRepository = new NhanVienRepository();
        DonViRepository _donViRepository = new DonViRepository();
        HocViRepository _hocViRepository = new HocViRepository();
        NgachRepository _ngachRepository = new NgachRepository();
        private readonly View.MainView _view;

        public BindingSource NhanVienBindingSource { get; set; } = new BindingSource();
        public BindingSource DonViBindingSource { get; set; } = new BindingSource();
        public BindingSource HocViBindingSource { get; set; } = new BindingSource();
        public BindingSource NgachBindingSource { get; set; } = new BindingSource();
        public DataBindingCenter(BindingSource nhanVienbindingSource, BindingSource donVibindingSource, 
            BindingSource hocVibindingSource, BindingSource ngachbindingSource, View.MainView mainView)
        {
            _view = mainView;
            NhanVienBindingSource = nhanVienbindingSource;
            DonViBindingSource = donVibindingSource;
            HocViBindingSource = hocVibindingSource;
            NgachBindingSource = ngachbindingSource;
            ReLoad();
        }
        public async void ReLoad()
        {
            var nhanViens = await _nhanVienRepository.GetList();
            var donVis = await _donViRepository.GetList();
            var hocVis = await _hocViRepository.GetList();
            var ngachs = await _ngachRepository.GetList();
            NhanVienBindingSource.DataSource = nhanViens;
            DonViBindingSource.DataSource = donVis;
            HocViBindingSource.DataSource = hocVis;
            NgachBindingSource.DataSource = ngachs;
            

        }
    }
}

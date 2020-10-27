using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Models
{
    public class NhanVien
    {
        public int NhanVienId { get; set; }
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string danToc;
        private string tonGiao;
        private int soDienThoai;
        private string email;
        private string diaChi;
        private int soCMND;
        private string anh;
        private bool dangVien;
        

        public NhanVien()
        {
            NhanVienId = 0;
            hoTen = "Chu Van Hoang";
            ngaySinh = DateTime.Now;
            gioiTinh = true;
            danToc = "Kinh";
            tonGiao = "Khong";
            soDienThoai = 0822234112;
            email = "hoang.scv@gmail.com";
            diaChi = "Thai Nguyen";
            SoCMND = 091900680;
            anh = "link...";
            HocViId = 111;
            DonViId = 222;
            HopDongId = 333;
            NgachId = 444;
            ChucVuId = 555;


        }
        public int HocViId { get; set; }
        public int DonViId { get; set; }
        public int HopDongId { get; set; }
        public int NgachId { get; set; }
        public int ChucVuId { get; set; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public int SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoCMND { get => soCMND; set => soCMND = value; }
        public string Anh { get => anh; set => anh = value; }
        public bool DangVien { get => dangVien; set => dangVien = value; }

        public virtual DonVi DonVi { get; set; }

        public virtual HocVi HocVi { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual Ngach Ngach { get; set; }


    }
}

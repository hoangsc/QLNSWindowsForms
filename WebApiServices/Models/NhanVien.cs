using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; }

        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        public string DanToc { get; set; }

        public string TonGiao { get; set; }

        public int SoDienThoai { get; set; }

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public int SoCMND { get; set; }

        public string Anh { get; set; }

        public bool DangVien { get; set; }

        public int HocViId { get; set; }

        public int DonViId { get; set; }

        public int HopDongId { get; set; }

        public int NgachId { get; set; }


        public virtual DonVi DonVi { get; set; }

        public virtual HocVi HocVi { get; set; }

        public virtual HopDong HopDong { get; set; }

        public virtual Ngach Ngach { get; set; }

    }
}
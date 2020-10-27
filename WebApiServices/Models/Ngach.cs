using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class Ngach
    {
        [Key]
        public int NgachId { get; set; }

        public string TenNgach { get; set; }

        public double HeSoLuong { get; set; }

        public int? Bac { get; set; }

        //public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
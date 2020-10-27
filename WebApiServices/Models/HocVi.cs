using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class HocVi
    {
        [Key]
        public int HocViId { get; set; }

        public string TenHocVi { get; set; }

        //public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
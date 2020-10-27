using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class DonVi
    {
        [Key]
        public int DonViId { get; set; }

        public string TenDonVi { get; set; }

        //public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
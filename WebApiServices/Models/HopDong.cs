using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class HopDong
    {
        public int HopDongId { get; set; }

        public DateTime NgayKi { get; set; }

        public DateTime NgayKetThuc { get; set; }
    }
}
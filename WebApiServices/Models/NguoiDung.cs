using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiServices.Models
{
    public class NguoiDung
    {
        [Key]
        public int NguoiDungId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
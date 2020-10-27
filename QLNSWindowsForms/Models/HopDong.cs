using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Models
{
    public class HopDong
    {
        public int HopDongId { get; set; }
        public DateTime NgayKi { get => ngayKi; set => ngayKi = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }

        private DateTime ngayKi;

        private DateTime ngayKetThuc;

        public HopDong()
        {
            HopDongId = 333;
            ngayKi = DateTime.Now;
            ngayKetThuc = DateTime.Now;
        }
    }
}

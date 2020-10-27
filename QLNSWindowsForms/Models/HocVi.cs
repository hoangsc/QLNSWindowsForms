using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Models
{
    public class HocVi
    {
        public int HocViId { get; set; }
        private string tenHocVi;
        public string TenHocVi { get => tenHocVi; set => tenHocVi = value; }
    }
}

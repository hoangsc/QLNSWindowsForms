using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSWindowsForms.Models
{
    public class DonVi
    {
        public int DonViId { get; set; }
        public string TenDonVi { get => tenDonVi; set => tenDonVi = value; }

        private string tenDonVi;
    }
}

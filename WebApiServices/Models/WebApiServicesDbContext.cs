using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiServices.Models
{
    public class WebApiServicesDbContext : DbContext
    {
        public WebApiServicesDbContext() : base("name = QLNSKhoaCNTTDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DonVi> DonVis { get; set; }
        public DbSet<HocVi> HocVis { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<Ngach> Ngachs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }


    }
}
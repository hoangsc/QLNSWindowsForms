using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{
    public class NhanVienRepository : IRepository<NhanVien>
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public void Add(NhanVien item)
        {
            _dbContext.NhanViens.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.NhanViens.Remove(_dbContext.NhanViens.FirstOrDefault(e => e.NhanVienId == id));
            _dbContext.SaveChanges();
        }

        public NhanVien Get(int id)
        {
            return _dbContext.NhanViens.Include("HocVi").Include("DonVi").Include("Ngach")
                .Include("HopDong").FirstOrDefault(e => e.NhanVienId == id);
        }

        public List<NhanVien> List()
        {
            return _dbContext.NhanViens.Include("HocVi").Include("DonVi").Include("Ngach")
                .Include("HopDong").ToList();

        }

        public void Update(NhanVien item, int id)
        {
            NhanVien nhanvien = _dbContext.NhanViens.Find(id);
            nhanvien.HoTen = item.HoTen;
            nhanvien.NgaySinh = item.NgaySinh;
            nhanvien.GioiTinh = item.GioiTinh;
            nhanvien.DanToc = item.DanToc;
            nhanvien.TonGiao = item.TonGiao;
            nhanvien.SoDienThoai = item.SoDienThoai;
            nhanvien.Email = item.Email;
            nhanvien.DiaChi = item.DiaChi;
            nhanvien.Anh = item.Anh;
            nhanvien.DangVien = item.DangVien;
            nhanvien.HocViId = item.HocViId;
            nhanvien.DonViId = item.DonViId;
            nhanvien.HopDongId = item.HopDongId;
            nhanvien.NgachId = item.NgachId;

            _dbContext.SaveChanges();
            
        }
    }
}
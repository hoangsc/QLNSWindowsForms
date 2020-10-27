using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{
    public class HopDongRepository : IRepository<HopDong>
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public HopDongRepository()
        {
        }

        public void Add(HopDong item)
        {
            _dbContext.HopDongs.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.HopDongs.Remove(_dbContext.HopDongs.FirstOrDefault(e => e.HopDongId == id));
            _dbContext.SaveChanges();
        }

        public HopDong Get(int id)
        {
            return _dbContext.HopDongs.FirstOrDefault(e => e.HopDongId == id);
        }

        public List<HopDong> List()
        {
            return _dbContext.HopDongs.ToList();
        }

        public void Update(HopDong item, int id)
        {
            HopDong HopDong = _dbContext.HopDongs.Find(id);
            HopDong.NgayKi = item.NgayKi;
            HopDong.NgayKetThuc = item.NgayKetThuc;
            _dbContext.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{
    public class NgachRepository : IRepository<Ngach>
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public NgachRepository()
        {
        }

        public void Add(Ngach item)
        {
            _dbContext.Ngachs.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.Ngachs.Remove(_dbContext.Ngachs.FirstOrDefault(e => e.NgachId == id));
            _dbContext.SaveChanges();
        }

        public Ngach Get(int id)
        {
            return _dbContext.Ngachs.FirstOrDefault(e => e.NgachId == id);
        }

        public List<Ngach> List()
        {
            return _dbContext.Ngachs.ToList();
        }

        public void Update(Ngach item, int id)
        {
            Ngach ngach = _dbContext.Ngachs.Find(id);
            ngach.Bac = item.Bac;
            ngach.TenNgach = item.TenNgach;
            ngach.HeSoLuong = item.HeSoLuong;
            _dbContext.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{
    public class HocViRepository : IRepository<HocVi>
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public HocViRepository()
        {
        }

        public void Add(HocVi item)
        {
            _dbContext.HocVis.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.HocVis.Remove(_dbContext.HocVis.FirstOrDefault(e => e.HocViId == id));
            _dbContext.SaveChanges();
        }

        public HocVi Get(int id)
        {
            return _dbContext.HocVis.FirstOrDefault(e => e.HocViId == id);
        }

        public List<HocVi> List()
        {
            return _dbContext.HocVis.ToList();
        }

        public void Update(HocVi item, int id)
        {
            HocVi HocVi = _dbContext.HocVis.Find(id);
            HocVi.TenHocVi = item.TenHocVi;
            _dbContext.SaveChanges();
        }
    }
}
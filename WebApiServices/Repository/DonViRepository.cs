using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{
    public class DonViRepository : IRepository<DonVi>
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public DonViRepository()
        {
        }
        public void Add(DonVi item)
        {
            _dbContext.DonVis.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext.DonVis.Remove(_dbContext.DonVis.FirstOrDefault(e => e.DonViId == id));
            _dbContext.SaveChanges();
        }

        public DonVi Get(int id)
        {
            return _dbContext.DonVis.FirstOrDefault(e => e.DonViId == id);
        }

        public List<DonVi> List()
        {
            return _dbContext.DonVis.ToList();
        }

        public void Update(DonVi item, int id)
        {
            DonVi DonVi = _dbContext.DonVis.Find(id);
            DonVi.TenDonVi = item.TenDonVi;
            _dbContext.SaveChanges();
        }
    }
}
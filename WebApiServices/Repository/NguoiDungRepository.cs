using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiServices.IRepository;
using WebApiServices.Models;

namespace WebApiServices.Repository
{

    public class NguoiDungRepository
    {
        private WebApiServicesDbContext _dbContext = new WebApiServicesDbContext();

        public NguoiDung GetNguoiDung(string username, string password)
        {
            return _dbContext.NguoiDungs.FirstOrDefault(e => e.Username == username && e.Password == password);
        }
    }
}
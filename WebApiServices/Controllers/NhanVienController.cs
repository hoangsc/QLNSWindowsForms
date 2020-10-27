using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApiServices.Models;
using WebApiServices.Repository;

namespace WebApiServices.Controllers
{
    public class NhanVienController : ApiController
    {
        private NhanVienRepository _repository = new NhanVienRepository();
        [HttpGet]
        [Route("api/Nhanvien")]
        public HttpResponseMessage GetNhanViens()
        {
            var nhanViens = _repository.List();
            if(nhanViens != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repository.List());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Khong co du lieu");
            }
        }


        [HttpGet]
        [Route("api/NhanVien/{id}")]
        public HttpResponseMessage GetNhanVien(int id)
        {
            var nhanVien = _repository.Get(id);
            try
            {
                if(nhanVien != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, nhanVien);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "NhanVien Not Found");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }


        [HttpDelete]
        [Route("api/NhanVien/{id}")]
        public HttpResponseMessage DeleteNhanVien(int id)
        {
            var nhanVien = _repository.Get(id);
            try
            {
                if (nhanVien != null)
                {
                    _repository.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, nhanVien);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "NhanVien Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

   
        [HttpPost]
        [Route("api/NhanVien")]
        public HttpResponseMessage PostNhanVien([FromBody] NhanVien nhanVien)
        {
            try
            {
                _repository.Add(nhanVien);
                return Request.CreateResponse(HttpStatusCode.OK, nhanVien);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }


        [HttpPut]
        [Route("api/NhanVien/{id}")]
        public HttpResponseMessage Put([FromBody]NhanVien nhanVien, int id)
        {
            var nhanVienCheck = _repository.Get(id);
            try
            {
                if (nhanVienCheck != null)
                {
                    _repository.Update(nhanVien, id);
                    return Request.CreateResponse(HttpStatusCode.OK, nhanVien);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "NhanVien Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

    }
}
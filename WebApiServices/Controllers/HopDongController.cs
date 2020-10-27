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
    public class HopDongController : ApiController
    {
        private HopDongRepository _repository = new HopDongRepository();

        [HttpGet]
        [Route("api/HopDong")]
        public HttpResponseMessage GetHopDongs()
        {
            var HopDongs = _repository.List();
            if (HopDongs != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repository.List());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Khong co du lieu");
            }
        }

        [HttpGet]
        [Route("api/HopDong/{id}")]
        public HttpResponseMessage GetHopDong(int id)
        {
            var HopDong = _repository.Get(id);
            try
            {
                if (HopDong != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, HopDong);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HopDong Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpDelete]
        [Route("api/HopDong/{id}")]
        public HttpResponseMessage DeleteHopDong(int id)
        {
            var HopDong = _repository.Get(id);
            try
            {
                if (HopDong != null)
                {
                    _repository.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, HopDong);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HopDong Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPost]
        [Route("api/HopDong")]
        public HttpResponseMessage PostHopDong([FromBody] HopDong HopDong)
        {
            try
            {
                _repository.Add(HopDong);
                return Request.CreateResponse(HttpStatusCode.OK, HopDong);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPut]
        [Route("api/HopDong/{id}")]
        public HttpResponseMessage Put([FromBody]HopDong HopDong, int id)
        {
            var HopDongCheck = _repository.Get(id);
            try
            {
                if (HopDongCheck != null)
                {
                    _repository.Update(HopDong, id);
                    return Request.CreateResponse(HttpStatusCode.OK, HopDong);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HopDong Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

    }
}
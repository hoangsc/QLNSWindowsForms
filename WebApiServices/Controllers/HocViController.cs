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
    public class HocViController : ApiController
    {
        private HocViRepository _repository = new HocViRepository();

        [HttpGet]
        [Route("api/HocVi")]
        public HttpResponseMessage GetHocVis()
        {
            var HocVis = _repository.List();
            if (HocVis != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repository.List());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Khong co du lieu");
            }
        }

        [HttpGet]
        [Route("api/HocVi/{id}")]
        public HttpResponseMessage GetHocVi(int id)
        {
            var HocVi = _repository.Get(id);
            try
            {
                if (HocVi != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, HocVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HocVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpDelete]
        [Route("api/HocVi/{id}")]
        public HttpResponseMessage DeleteHocVi(int id)
        {
            var HocVi = _repository.Get(id);
            try
            {
                if (HocVi != null)
                {
                    _repository.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, HocVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HocVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPost]
        [Route("api/HocVi")]
        public HttpResponseMessage PostHocVi([FromBody] HocVi HocVi)
        {
            try
            {
                _repository.Add(HocVi);
                return Request.CreateResponse(HttpStatusCode.OK, HocVi);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPut]
        [Route("api/HocVi/{id}")]
        public HttpResponseMessage Put([FromBody]HocVi HocVi, int id)
        {
            var HocViCheck = _repository.Get(id);
            try
            {
                if (HocViCheck != null)
                {
                    _repository.Update(HocVi, id);
                    return Request.CreateResponse(HttpStatusCode.OK, HocVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "HocVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

    }
}
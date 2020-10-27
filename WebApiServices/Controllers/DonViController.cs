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
    public class DonViController : ApiController
    {
        private DonViRepository _repository = new DonViRepository();

        [HttpGet]
        [Route("api/DonVi")]
        public HttpResponseMessage GetDonVis()
        {
            var DonVis = _repository.List();
            if (DonVis != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repository.List());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Khong co du lieu");
            }
        }

        [HttpGet]
        [Route("api/DonVi/{id}")]
        public HttpResponseMessage GetDonVi(int id)
        {
            var DonVi = _repository.Get(id);
            try
            {
                if (DonVi != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, DonVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "DonVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpDelete]
        [Route("api/DonVi/{id}")]
        public HttpResponseMessage DeleteDonVi(int id)
        {
            var DonVi = _repository.Get(id);
            try
            {
                if (DonVi != null)
                {
                    _repository.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, DonVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "DonVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPost]
        [Route("api/DonVi")]
        public HttpResponseMessage PostDonVi([FromBody] DonVi DonVi)
        {
            try
            {
                _repository.Add(DonVi);
                return Request.CreateResponse(HttpStatusCode.OK, DonVi);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPut]
        [Route("api/DonVi/{id}")]
        public HttpResponseMessage Put([FromBody]DonVi DonVi, int id)
        {
            var DonViCheck = _repository.Get(id);
            try
            {
                if (DonViCheck != null)
                {
                    _repository.Update(DonVi, id);
                    return Request.CreateResponse(HttpStatusCode.OK, DonVi);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "DonVi Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

    }
}
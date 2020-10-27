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
    public class NgachController : ApiController
    {
        private NgachRepository _repository = new NgachRepository();

        [HttpGet]
        [Route("api/Ngach")]
        public HttpResponseMessage GetNgachs()
        {
            var Ngachs = _repository.List();
            if (Ngachs != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _repository.List());
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Khong co du lieu");
            }
        }

        [HttpGet]
        [Route("api/Ngach/{id}")]
        public HttpResponseMessage GetNgach(int id)
        {
            var Ngach = _repository.Get(id);
            try
            {
                if (Ngach != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, Ngach);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Ngach Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpDelete]
        [Route("api/Ngach/{id}")]
        public HttpResponseMessage DeleteNgach(int id)
        {
            var Ngach = _repository.Get(id);
            try
            {
                if (Ngach != null)
                {
                    _repository.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, Ngach);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Ngach Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPost]
        [Route("api/Ngach")]
        public HttpResponseMessage PostNgach([FromBody] Ngach Ngach)
        {
            try
            {
                _repository.Add(Ngach);
                return Request.CreateResponse(HttpStatusCode.OK, Ngach);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

        [HttpPut]
        [Route("api/Ngach/{id}")]
        public HttpResponseMessage Put([FromBody]Ngach Ngach, int id)
        {
            var NgachCheck = _repository.Get(id);
            try
            {
                if (NgachCheck != null)
                {
                    _repository.Update(Ngach, id);
                    return Request.CreateResponse(HttpStatusCode.OK, Ngach);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Ngach Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }

    }
}
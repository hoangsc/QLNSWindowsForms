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
    public class LoginController:ApiController
    {
        private NguoiDungRepository _repository = new NguoiDungRepository();

        [HttpPost]
        [Route("api/Login")]
        public HttpResponseMessage PostNguoiDung([FromBody] NguoiDung userInput)
        {
            var user = _repository.GetNguoiDung(userInput.Username, userInput.Password);
            try
            {
                if (user != null)
                {  
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "NguoiDung Not Found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Lỗi không xác định", ex);
            }
        }
    }
}
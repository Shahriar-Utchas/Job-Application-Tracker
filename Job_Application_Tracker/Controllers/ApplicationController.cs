using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Job_Application_Tracker.Controllers
{
    public class ApplicationController : ApiController
    {
        [HttpGet]
        [Route("api/applications/getAll")]
        public HttpResponseMessage getApplications()
        {
            var data = ApplicationService.GetApplications();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}

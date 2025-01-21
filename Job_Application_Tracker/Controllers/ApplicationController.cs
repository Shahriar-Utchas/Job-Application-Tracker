using BLL.DTOs;
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
        [HttpGet]
        [Route("api/applications/get/{id}")]
        public HttpResponseMessage getApplication(int id)
        {
            var data = ApplicationService.GetApplication(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/add")]
        public HttpResponseMessage addApplication(ApplicationDTO app)
        {
            var data = ApplicationService.AddApplication(app);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/update")]
        public HttpResponseMessage updateApplication(ApplicationDTO app)
        {
            var data = ApplicationService.UpdateApplication(app);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/delete/{id}")]
        public HttpResponseMessage deleteApplication(int id)
        {
            var data = ApplicationService.DeleteApplication(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/userAppDetails/{id}")]
        public HttpResponseMessage userApplicationDetails(int id)
        {
            var data = ApplicationService.UserApplicationDetails(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/applicationStatus/{status}")]
        public HttpResponseMessage applicationStatus(string status)
        {
            var data = ApplicationService.GetApplicationsStatus(status);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/applications/updateStatus/{appId}/{newStatus}")]
        public HttpResponseMessage updateApplicationStatus(int appId, string newStatus)
        {
            var data = ApplicationService.UpdateApplicationStatus(appId, newStatus);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/applications/track/{id}")]
        public HttpResponseMessage trackApplication(int id)
        {
            var data = ApplicationService.Applicationtrack(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}

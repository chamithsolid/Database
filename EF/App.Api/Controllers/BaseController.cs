using App.DbService;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Api.Controllers
{
    public class BaseController : ApiController
    {
        protected IStudentDbService student;
        public BaseController() {
            student = new StudentDbService();
        }
    }
}

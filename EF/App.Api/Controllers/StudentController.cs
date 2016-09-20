using App.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Api.Controllers
{
    public class StudentController : BaseController
    {
        [HttpPost]
        public IHttpActionResult Create(StudentViewModel item) {

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}

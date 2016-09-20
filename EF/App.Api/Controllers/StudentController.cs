using App.Api.Models;
using App.Domain;
using AutoMapper;
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
        public HttpResponseMessage Create(StudentViewModel item) {
            try
            {
                student.Create(Mapper.Map<Student>(item));
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage Update(StudentViewModel item) {
            try
            {
                student.Update(Mapper.Map<Student>(item));
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpDelete]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                student.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage Search(string q)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, student.Search(q).Select(x => AutoMapper.Mapper.Map<StudentViewModel>(x)).ToList());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage Read(int Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, Mapper.Map<StudentViewModel>(student.Read(Id)));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage Read()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, student.Read().Select(x => AutoMapper.Mapper.Map<StudentViewModel>(x)).ToList());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}

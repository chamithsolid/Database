using App.Api.Models;
using App.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Api.App_Start
{
    public class Automapper
    {
        public static  void RegisterAutomapper()
        {
            Mapper.CreateMap<StudentViewModel, Student>();
            Mapper.CreateMap<Student, StudentViewModel>();
        }
    }
}
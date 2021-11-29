using CoreSample.Models;
using CoreSample.Repository;
using CoreSample.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Controllers
{
    public class StudentsController : Controller
    {
        //private readonly ApplicationDbContext _applicationDbContext;
        //public StudentsController(ApplicationDbContext applicationDbContext)
        //{
        //    _applicationDbContext = applicationDbContext;

        //}
        private readonly IStudentRepository _repository;
        private readonly IEmailServices _emailServices;
        public StudentsController(IStudentRepository repository,IEmailServices emailServices)
        {
            _repository = repository;
            _emailServices = emailServices;
        }
        public IActionResult Index()
        {
            
            var students = _repository.GetAllStudent();
            return View(students);
        }

        public void EmailStudent()
        {
            Message message = new Message()
            {
            To="Kalai.com",
            From ="Arasy",
            Body="dfsdfs"
            };
            _emailServices.SendEmail(message);
            
        }
    }
}

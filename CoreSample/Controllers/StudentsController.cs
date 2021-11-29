using CoreSample.Models;
using CoreSample.Repository;
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
        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var students = _repository.GetAllStudent();
            return View();
        }
    }
}

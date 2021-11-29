using CoreSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSample.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }
        public void AddStudent(Student student)
        {
            _applicationDbContext.Add(student);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _applicationDbContext.Students.ToList();
        }

        
        public Student GetStudentById(int id)
        {
            return _applicationDbContext.Students.Find(id);
        }

        public void UpdateStudent(Student student)
        {
            _applicationDbContext.Entry(student).State = EntityState.Modified;
            _applicationDbContext.SaveChanges();
        }

        
    }
}

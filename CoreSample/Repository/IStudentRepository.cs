using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSample.Models;

namespace CoreSample.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        IEnumerable<Student> GetAllStudent();
        Student GetStudentById(int id);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentByID(int id);
    }
}

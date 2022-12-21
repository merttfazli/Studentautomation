using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        GenericRepositories<Student> efStudentRepositories;
        public StudentManager()
        {
            efStudentRepositories = new GenericRepositories<Student>();
        }
        public void AddStudent(Student student)
        {
            efStudentRepositories.Insert(student);
        }

        public void DeleteStudent(Student student)
        {
            if (student.Id != 0)
            {
                efStudentRepositories.Delete(student);
            }
        }

        public List<Student> GetAllStudents()
        {
            return efStudentRepositories.GetAllList();
        }

        public Student GetStudentByID(int id)
        {
            return efStudentRepositories.GetById(id);
        }

        public void UpdateStudent(Student student)
        {
            if (student.Id != 0)
            {
                efStudentRepositories.Update(student);
            }
        }
    }
}

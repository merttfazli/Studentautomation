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
    public class AdminManager : IAdminService
    {
        AdminRepositories<Admin> efAdminRepositories;

        public AdminManager() { efAdminRepositories = new AdminRepositories<Admin>(); }

        public List<Lesson> GetAllLessons()
        {
            return efAdminRepositories.GetAllLesson();
        }

        public List<Student> GetAllStudents()
        {
            return efAdminRepositories.GetAllStudent();
        }

        public List<Teacher> GetAllTeachers()
        {
            return efAdminRepositories.GetAllTeachers();
        }

        public void GiveLessonToTeacher(Lesson lesson, Teacher teacher)
        {
            if (!(lesson == null && teacher == null))
            {
                efAdminRepositories.Insert(lesson, teacher);
            }
        }

        public void RemoveLessonFromTeacher(Lesson lesson, Teacher teacher)
        {
            if (!(lesson == null && teacher == null))
            {
                efAdminRepositories.Remove(lesson, teacher);
            }
        }
    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        public List<Teacher> GetAllTeachers();
        public List<Lesson> GetAllLessons();
        public List<Student> GetAllStudents();
        public void GiveLessonToTeacher(Lesson lesson,Teacher teacher);
        public void RemoveLessonFromTeacher(Lesson lesson,Teacher teacher);

       
    }
}

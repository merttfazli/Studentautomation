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
    public class TeacherManager : ITeacherService
    {
        GenericRepositories<Teacher> efTeacherRepositories;
        public TeacherManager() { efTeacherRepositories = new GenericRepositories<Teacher>(); }
        public void AddTeacher(Teacher teacher)
        {
            efTeacherRepositories.Insert(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            if (teacher.Id != 0)
            {
                efTeacherRepositories.Delete(teacher);
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            return efTeacherRepositories.GetAllList();
        }

        public Teacher GetTeacherById(int id)
        {
            return efTeacherRepositories.GetById(id);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            if (teacher.Id != 0)
            {
                efTeacherRepositories.Update(teacher);
            }
        }
    }
}

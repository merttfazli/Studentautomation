using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        public void AddTeacher(Teacher teacher);
        public void UpdateTeacher(Teacher teacher);
        public void DeleteTeacher(Teacher teacher);
        public List<Teacher> GetAllTeachers();
        public Teacher GetTeacherById(int id);

    }
}

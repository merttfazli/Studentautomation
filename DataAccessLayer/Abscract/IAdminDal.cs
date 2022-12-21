using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abscract
{
   public interface IAdminDal<T> where T : class
    {
        
        List<Student> GetAllStudent();
        List<Lesson> GetAllLesson();
        List<Teacher> GetAllTeachers();
       

        
    }
}

using DataAccessLayer.Abscract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AdminRepositories<T> : IAdminDal<T> where T : class
    {
        public List<Lesson> GetAllLesson()
        {
            using var c = new Context();
            return c.Set<Lesson>().ToList();
        }

        public List<Student> GetAllStudent()
        {
            using var c = new Context();
            return c.Set<Student>().ToList();
        }

        public List<Teacher> GetAllTeachers()
        {
            using var c = new Context();
            return c.Set<Teacher>().ToList();
        }

        public void Insert(Lesson L,Teacher T)
        {
            using var c = new Context();
            c.Add(L);
            c.Add(T);
            c.SaveChanges();
        }
        public void Remove(Lesson L,Teacher T)
        {
            using var c = new Context();
            c.Remove(L);
            c.Remove(T);
        }


    }
}

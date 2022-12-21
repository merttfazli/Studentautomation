using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService
    {
        public void AddLesson(Lesson lesson);
        public void UpdateLesson(Lesson lesson);
        public void DeleteLesson(Lesson lesson);
        public List<Lesson> GetAllLessons();
        public Lesson GetLessonById(int id);

    }
}

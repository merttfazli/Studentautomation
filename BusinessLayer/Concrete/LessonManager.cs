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
    public class LessonManager : ILessonService
    {
        GenericRepositories<Lesson> efLessonRepositories;
        public LessonManager() { efLessonRepositories = new GenericRepositories<Lesson>(); }
        public void AddLesson(Lesson lesson)
        {
            efLessonRepositories.Insert(lesson);
        }

        public void DeleteLesson(Lesson lesson)
        {
            if (lesson.Id != 0)
            {
                efLessonRepositories.Delete(lesson);
            }
        }

        public List<Lesson> GetAllLessons()
        {
            return efLessonRepositories.GetAllList();
        }

        public Lesson GetLessonById(int id)
        {
            return efLessonRepositories.GetById(id);
        }

        public void UpdateLesson(Lesson lesson)
        {
            if (lesson.Id != 0)
            {
                efLessonRepositories.Update(lesson);
            }
        }
    }
}

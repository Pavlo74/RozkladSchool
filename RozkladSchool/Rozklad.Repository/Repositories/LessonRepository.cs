using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class LessonRepository
    {
        private readonly RozkladContext _ctx;
        public LessonRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Lesson> AddLessonAsync(Lesson lesson)
        {
            _ctx.Lessons.Add(lesson);
            await _ctx.SaveChangesAsync();
            return _ctx.Lessons.FirstOrDefault(x => x.LessonName == lesson.LessonName);
        }

        public Lesson GetLesson(int id)
        {
            return _ctx.Lessons.Include(x => x.Discipline).Include(x => x.Teacher).Include(x => x.Pupil).FirstOrDefault(x => x.LessonId == id);
        }

        public Lesson GetLessonByName(string name)
        {
            return _ctx.Lessons.Include(x => x.Discipline).Include(x => x.Teacher).Include(x => x.Pupil).FirstOrDefault(x => x.LessonName == name);
        }

        public List<Lesson> GetLessons()
        {
            var lessonList = _ctx.Lessons.ToList();
            return lessonList;
        }

        public async Task DeleteVehicleModelAsync(int id)
        {
            _ctx.Remove(GetLesson(id));
            await _ctx.SaveChangesAsync();
        }
    }
}

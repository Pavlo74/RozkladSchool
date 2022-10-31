using Rozklad.Core;
using Rozklad.Repository.Dto.TeacherDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
   public class TeacherRepository
    {
        private readonly RozkladContext _ctx;
        public TeacherRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            _ctx.Teachers.Add(teacher);
            await _ctx.SaveChangesAsync();
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherName == teacher.TeacherName);
        }

        public List<Teacher> GetTeachers()
        {
            var teacherList = _ctx.Teachers.ToList();
            return teacherList;
        }

        public Teacher GetTeacher(int id)
        {
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherId == id);
        }

        public Teacher GetTeacherByName(string name)
        {
            return _ctx.Teachers.FirstOrDefault(x => x.TeacherName == name);
        }

        public async Task DeleteTeacherAsync(int id)
        {
            _ctx.Remove(GetTeacher(id));
            await _ctx.SaveChangesAsync();
        }
    }
}

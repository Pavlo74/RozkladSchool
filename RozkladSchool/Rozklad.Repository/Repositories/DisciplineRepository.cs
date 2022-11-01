using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.DisciplineDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class DisciplineRepository
    {

        /*private readonly RozkladContext _ctx;
        public DisciplineRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Discipline> AddDisciplineAsync(Discipline discipline)
        {
            _ctx.Disciplines.Add(discipline);
            await _ctx.SaveChangesAsync();
            return _ctx.Disciplines.FirstOrDefault(x => x.DisciplineName == discipline.DisciplineName);
        }

        public List<Discipline> GetDisciplines()
        {
            var disciplineList = _ctx.Disciplines.ToList();
            return disciplineList;
        }

        public Discipline GetDiscipline(int id)
        {
            return _ctx.Disciplines.Include(x => x.Teacher).FirstOrDefault(x => x.DisciplineId == id);
        }

        public Discipline GetDisciplineByName(string name)
        {
            return _ctx.Disciplines.Include(x => x.Teacher).FirstOrDefault(x => x.DisciplineName == name);
        }

        public async Task DeleteCabinetAsync(int id)
        {
            _ctx.Remove(GetDiscipline(id));
            await _ctx.SaveChangesAsync();
        }*/
    }
}

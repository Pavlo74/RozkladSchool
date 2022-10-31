using Rozklad.Core;
using Rozklad.Repository.Dto.PupilDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class PupilRepository
    {
        private readonly RozkladContext _ctx;
        public PupilRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Pupil> AddPupilAsync(Pupil pupil)
        {
            _ctx.Pupils.Add(pupil);
            await _ctx.SaveChangesAsync();
            return _ctx.Pupils.FirstOrDefault(x => x.PupilName == pupil.PupilName);
        }

        public List<Pupil> GetPupils()
        {
            var pupilList = _ctx.Pupils.ToList();
            return pupilList;
        }

        public Pupil GetPupil(int id)
        {
            return _ctx.Pupils.FirstOrDefault(x => x.PupilId == id);
        }

        public Pupil GetPupilByName(string name)
        {
            return _ctx.Pupils.FirstOrDefault(x => x.PupilName == name);
        }

        public async Task DeleteTeacherAsync(int id)
        {
            _ctx.Remove(GetPupil(id));
            await _ctx.SaveChangesAsync();
        }
    }
}

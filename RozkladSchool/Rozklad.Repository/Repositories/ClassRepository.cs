using Microsoft.EntityFrameworkCore;
using Rozklad.Core;
using Rozklad.Repository.Dto.ClassDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
    public class ClassRepository
    {

        private readonly RozkladContext _ctx;
        public ClassRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

       public async Task<IEnumerable<ClassReadDto>> GetClassTypesAsync()
        {
            var classDto = _ctx.Classes.
                Select(x => new ClassReadDto
                {
                    ClassId = x.ClassId,
                    ClassName = x.ClassName,


                  
                    Timetables = x.Timetables
                }).ToList();

            return classDto;
        }

        /*public async Task<User> CreateClassAsync(string? className)
        {
            var newClass = new Class
            {
                ClassName = className,
                
            };

            return await _ctx.Users.FirstAsync(x => x.Id == id);
        }*/
    }
}

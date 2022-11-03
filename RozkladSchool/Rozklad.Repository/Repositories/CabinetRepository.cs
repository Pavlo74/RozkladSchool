using Rozklad.Core;
using Rozklad.Repository.Dto.CabinetDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad.Repository.Repositories
{
 public class CabinetRepository
    {
        private readonly RozkladContext _ctx;
        public CabinetRepository(RozkladContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Cabinet> AddCabinetAsync(Cabinet cabinet)
        {
            _ctx.Cabinets.Add(cabinet);
            await _ctx.SaveChangesAsync();
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == cabinet.CabinetName);
        }

        public List<Cabinet> GetCabinets()
        {
            var cabinetList = _ctx.Cabinets.ToList();
            return cabinetList;
        }

        public Cabinet GetCabinet(int id)
        {
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetId == id);
        }

        public Cabinet GetCabinetByName(string name)
        {
            return _ctx.Cabinets.FirstOrDefault(x => x.CabinetName == name);
        }

        public async Task DeleteCabinetAsync(int id)
        {
            _ctx.Remove(GetCabinet(id));
            await _ctx.SaveChangesAsync();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Rozklad.Repository;

namespace RozkladSchool.Controllers
{
    public class UpdateController : Controller
    {
        private readonly UpdateRepository updateRepository;
        public UpdateController(UpdateRepository updateRepository)
        {
            this.updateRepository = updateRepository;
        }

        public async Task<List<string>> Run()
        {
            return await updateRepository.UpdateAsync();
        }
    }
}

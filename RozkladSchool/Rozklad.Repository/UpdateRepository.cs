using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Rozklad.Core;

namespace Rozklad.Repository
{
    public class UpdateRepository
    {
        private readonly RozkladContext _ctx;
        private readonly IConfiguration _configuration;

        public UpdateRepository(RozkladContext ctx, IConfiguration configuration)
        {
            _ctx = ctx;
            _configuration= configuration;
        }

        public async Task<List<string>> UpdateAsync()
        {
            HttpClient client = new HttpClient();
            var url = _configuration["Update:GithubUrl"];
            return new List<string> { url };
        }
           

    }
}

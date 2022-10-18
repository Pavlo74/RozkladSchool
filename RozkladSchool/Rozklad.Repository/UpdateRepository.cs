using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Rozklad.Core;
using Rozklad.Repository.Converters;
using Rozklad.Repository.Dto;

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
            var jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.Converters.Add(new IntJsonConverter());

            var data = await client.GetStringAsync(url);
            Console.WriteLine(data);
            data = data.Replace("NaN", "0");

            var list=JsonSerializer.Deserialize<List<LessonReadJson>>(data, jsonSerializerOptions);
            // var existing = _ctx.Lesson.ToList();
            var existing = _ctx.Lessons.ToList();
            foreach (var item in list)


            {
                if (!existing.Any(x => x.LessonNumber == item.Lesson))
                {
                    //messageList.Add($"Додано дані за {item.Date.Value.ToString("dd.MM.yyyy")}.");

                    await _ctx.Lessons.AddRangeAsync(new List<Lesson> {
                        new Lesson
                        {
                            LessonNumber=item.Lesson,
                            LessonId=item.Lesson
                          /* Date = item.Date.Value,
                            Type = await _ctx.EquipmentTypes.FindAsync(1),
                            Count = item.Aircraft*/
                        },
                        
                    });

                }
            }
            await _ctx.SaveChangesAsync();
            return new List<string> { url,$"count{list.Count}"};
        }
           

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto
{
   public class LessonReadJson
    {
        [JsonPropertyName("Lesson")]
        public int Lesson { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto
{
   public class CabinetReadJson
    {
       /* [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        [JsonPropertyName("day")]
        public int Day { get; set; }

        [JsonPropertyName("Class")]
        public int Class { get; set; }
        [JsonPropertyName("Lesson")]
        public int Lesson { get; set; }*/

        [JsonPropertyName("Cabinet")]
        public int Cabinet { get; set; }

       /* [JsonPropertyName("Disipline")]
        public int Disipline{ get; set; }*/

    }
}

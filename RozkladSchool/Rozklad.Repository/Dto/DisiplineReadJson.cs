using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto
{
 public class DisiplineReadJson
    {
        [JsonPropertyName("Disipline")]
        public int Disipline { get; set; }
    }
}

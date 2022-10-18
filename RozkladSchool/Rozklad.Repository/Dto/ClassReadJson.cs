using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rozklad.Repository.Dto
{
  public class ClassReadJson
    {
        [JsonPropertyName("Class")]
        public int Class { get; set; }
    }
}

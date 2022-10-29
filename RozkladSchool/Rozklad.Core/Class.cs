using System.ComponentModel.DataAnnotations;

namespace Rozklad.Core
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public virtual ICollection<Section>? Sections { get; set; }
        
    }
}
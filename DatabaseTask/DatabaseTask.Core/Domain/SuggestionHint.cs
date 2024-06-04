using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class SuggestionHint
    {
        [Key]
        public int ID { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
        public Guid EmployeeID { get; set; }
        public string Status { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
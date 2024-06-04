using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        [Key]
        public int ID { get; set; }
        public Guid EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
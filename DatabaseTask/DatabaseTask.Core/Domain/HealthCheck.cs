using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public int ID { get; set; }
        public Guid EmployeeID { get; set; }
        public DateTime Date { get; set; }
        public string DoctorName { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
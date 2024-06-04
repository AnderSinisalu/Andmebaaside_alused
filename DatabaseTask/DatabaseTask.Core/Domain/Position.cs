using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Position
    {
        [Key]
        public int ID { get; set; }
        public float Salary { get; set; }
        public string PositionTitle { get; set; }
        public string Description {get; set; }
        public ICollection<JobTenure> JobTenures { get; set; }
    }
}
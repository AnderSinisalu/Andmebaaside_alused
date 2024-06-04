using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItem
    {
        [Key]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string LoanStatus { get; set; }

        public ICollection<Loaning> Loanings { get; set; }
    }
}
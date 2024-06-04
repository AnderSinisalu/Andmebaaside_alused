using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Address { get; set; }

        public ICollection<Child> Children { get; set; }
        public ICollection<AccessLevel> AccessLevels { get; set; }
        public ICollection<HealthCheck> HealthChecks { get; set; }
        public ICollection<Loaning> Loanings { get; set; }
        public ICollection<SickLeave> SickLeaves { get; set; }
        public ICollection<Vacation> Vacations { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<JobTenure> JobTenures { get; set; }


    }
}


﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class AccessLevel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PermissionList { get; set; }
        public Guid EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
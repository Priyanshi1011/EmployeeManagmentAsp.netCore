﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagmentNew.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string Qualification { get; set; }
        [Display(Name = "ContectNumber")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                    ErrorMessage = "Entered phone format is not valid.")]
        public String ContectNumber { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}

using MyWebApp.Controllers;
using MyWebApp.Models.DLA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MyWebApp.Models
{
    public class EmployeeViewModel 
    {
       
        public long emp_id { get; set; }
        [Required(ErrorMessage = "Please enter your Job Name")]
        [Display(Name = "Job Name")]
        [MaxLength(50)]
        public string job_name { get; set; }

        [Required(ErrorMessage = "Please enter your Emp Name")]
        [Display(Name = "Emp Name")]
        [MaxLength(50)]
        public string Emp_name { get; set; }
        
        [Required(ErrorMessage = "The email address is required")]
        [Display(Name = "Email address")]       
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        [Display(Name = "Address")]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your Dept_id")]
        [Display(Name = "Dept_id")]
        [MaxLength(50)]
        public string dept_id { get; set; }
    }
}
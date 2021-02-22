using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DTOs
{
    public class StudentDTO
    {
        [Required(ErrorMessage = "The flied is required")]
        public int ID { get; set; }
        [Required(ErrorMessage = "The flied is required")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The flied is required")]
        [Display(Name = "First name")]
        public string FirstMidName { get; set; }
        [Required(ErrorMessage = "The flied is required")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Data.Entities
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "First name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "FullName")]
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

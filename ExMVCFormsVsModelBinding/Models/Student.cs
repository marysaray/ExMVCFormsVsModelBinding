using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExMVCFormsVsModelBinding.Models
{
    /// <summary>
    /// Represents an individual Student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier for the student.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The legal first and last name of the student.
        /// </summary>
        [Display(Name ="Full Name:")]
        [Required(ErrorMessage ="Please enter a name.")]
        public string FullName { get; set; }

        /// <summary>
        /// MM/DD/YYYY : Time is ignored.
        /// </summary>
        [Display(Name ="Date of Birth:")]
        [DataType(DataType.Date)] // without time
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student school email: @students.cptc.edu
        /// </summary>
        [Display(Name ="Email:")]
        [DataType(DataType.EmailAddress)] // validation for email
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Best way to contact via phone.
        /// </summary>
        [Display(Name ="Phone Number:")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
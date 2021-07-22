using System;
using System.Collections.Generic;
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
        public string FullName { get; set; }

        /// <summary>
        /// MM/DD/YYYY : Time is ignored.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student school email: @students.cptc.edu
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Best way to contact via phone.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
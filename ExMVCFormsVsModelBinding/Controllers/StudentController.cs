using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ExMVCFormsVsModelBinding.Models;

namespace ExMVCFormsVsModelBinding.Controllers
{
    public class StudentController : Controller
    {
        // Add student to database: attribute are placed above the method with []

        [HttpGet] // navigates to form linked to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // retrieve data after submission: get data from the server
        public IActionResult Add(IFormCollection form)
        {
            // extract data: create instance of student object
            Student stu = new Student();
            stu.FullName = form["full-name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]); // convert to datetime
            stu.PhoneNumber = form["phone"];
            stu.EmailAddress = form["email"];

            return View();
        }
    }
}
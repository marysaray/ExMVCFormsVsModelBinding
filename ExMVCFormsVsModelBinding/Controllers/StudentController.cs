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
        // attribute are placed above the method with []

        [HttpGet] // navigates to form linked to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // retrieve data after submission: get data from the server
        public IActionResult Add(IFormCollection form)
        {
            // TODO: server-side validation for all data

            // extract data: create instance of student object
            Student stu = new Student();
            stu.FullName = form["full-name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]); // convert to datetime
            stu.PhoneNumber = form["phone"];
            stu.EmailAddress = form["email"];

            // Add student to database: 

            // display message and hide form
            ViewData["Added"] = stu.FullName + " was added with an ID of 1";

            return View();
        }

        [HttpGet] // navigates to form linked to URL
        public IActionResult AddWithBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWithBinding(Student student) // model binding mapping with object
        {
            // validation code: data annotation in Student class
            if (ModelState.IsValid) // true if all validation in model passes
            {
                // display message
                ViewData["Message"] = $"{student.FullName} was successfully added!";
                // Add to database here...
            }
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExMVCFormsVsModelBinding.Controllers
{
    public class StudentController : Controller
    {
        // Add student to database
        public IActionResult Add()
        {
            return View();
        }
    }
}
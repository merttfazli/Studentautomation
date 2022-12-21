using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace Studentautomation.Controllers
{
    public class StudentController: System.Web.Mvc.Controller
    {
        StudentManager studentManager = new StudentManager();
        public IActionResult Index()
        {
            var values = studentManager.GetAllStudents();
            return (IActionResult)View(values);
        }
    }
}

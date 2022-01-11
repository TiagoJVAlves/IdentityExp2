using IdentityExp2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExp2.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }
        public IActionResult Index()
        {
            ViewBag.TeacherList = _classService.GetTeacherList();
            return View();
        }
    }
}

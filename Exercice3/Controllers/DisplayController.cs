using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercice3.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
           
            ViewData["Prenom"] = "toto";
            ViewData["Age"] = 20;
            ViewData["Hobbies"]=new List<string>() {"-Sport","-Lecture","-Voyage" };
            return View();
        }
    }
}

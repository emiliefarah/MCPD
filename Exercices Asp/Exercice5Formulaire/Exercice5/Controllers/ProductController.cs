using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice5.Controllers
{
    [Route("Acceuil")]
    public class ProductController : Controller
    {
        [HttpPost("Product")]
        public IActionResult CreerProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("AfficherProduct", product);
            }
            return RedirectToAction("Succes");

        }
        [HttpGet("Product")]
        public IActionResult AfficherProduct()
        {
            Product product = new Product();
            return View(product);
        }
        [Route("Chocolat")]
            public IActionResult Succes()
        {
            return View();
        }
    }
}

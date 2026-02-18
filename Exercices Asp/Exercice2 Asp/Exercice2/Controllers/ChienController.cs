using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice2.Controllers
{
    public class ChienController : Controller
    {
        public List<Chien> Chiens { get; set; }

        public ChienController()
        {
            Chiens = new List<Chien>();
            Chiens.Add(new Chien(1, "Naya", 4, "Berger Americain"));
            Chiens.Add(new Chien(2, "Brutus", 6, "Berger Allemand"));
            Chiens.Add(new Chien(3, "Ulysse", 3, "Bichon"));
            Chiens.Add(new Chien(4, "Pinceau", 7, "Dalmatien"));
        }
        public IActionResult AfficherChien(int id)
        {
            Chien chien = Chiens.Where(c => c.Id == id).Single();
        ViewData["Chien"]= chien;

           
            return View();
        }

        public IActionResult AfficherToutLesChiens()
        {
            string leschiens = "";
            foreach (var chien in Chiens)
            {
                leschiens += chien + "\n";
            }

            ViewBag.Chiens = leschiens;
            return View();
        }
        public IActionResult AfficherMessageDeBienvenue(string nom)
        {
            if (nom == null || nom.Length == 0)
                nom = "Defaut";

            ViewBag.Nom = nom;
           return View ();
        }
    }
}

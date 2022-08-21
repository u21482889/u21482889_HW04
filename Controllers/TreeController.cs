using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21482889_HW04.Models;
namespace u21482889_HW04.Controllers
{
    public class TreeController : Controller
    {
        // GET: Tree
      
        public ActionResult HomePage()
        {
          
            return View();
        }

        [HttpPost]

        public ActionResult HomePage( Tree tree)
        {
           
            return View();
        }

        public ActionResult Pollution(Tree tree)
        {
            ViewBag.Message = tree.EcoSuggestions();

          

            return View();
        } 

        public ActionResult Fruit()
        {
            return View();

        }

        public ActionResult Low()
        { 
            
            return View();

        }
        
    }
}
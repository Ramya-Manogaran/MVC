using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assignment.Models;

namespace Assignment.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        public static List<Product> list = new List<Product>()
        {
            new Product(){Pid = 1, Pname = "Manohar", Price = 150, Stock = 9},
            new Product(){Pid = 2, Pname = "Rukmani", Price = 200, Stock = 10},
            new Product(){Pid = 3, Pname = "Santosh", Price = 250, Stock = 11},
            new Product(){Pid = 4, Pname = "Ramya", Price = 300, Stock = 12}
        };

        public ActionResult getlist()
        {
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int Pid, string Pname, int Price, int Stock)
        {
            //adding project data to list
            Product p = new Product() { Pid = Pid, Pname = Pname, Price = Price, Stock = Stock };
            list.Add(p);
            ViewData["1"] = Pid;
            ViewData["2"] = Pname;
            ViewData["3"] = Price;
            ViewData["4"] = Stock;
            return View("greet");
        }
        public ActionResult Greet()
        {
            return View();
        }
    }
}
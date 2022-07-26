﻿using Microsoft.AspNetCore.Mvc;
using ProyectoEntropy.Models;
//using ProyectoEntropy.Models.ViewModels;
using System.Diagnostics;

namespace ProyectoEntropy.Controllers
{
    public class HomeController : Controller
    {

     
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //List<ListTableViewModels> lst;

            //using ( db =new ())
            //    lst = (from d in db.EmployeeType
            //           select new ListTableViewModels
            //           {
            //               Id = d.Id,
            //               Names = d.Name,
            //               RoleDescription = d.RoleDescription,
            //               DateCreated = d.DateCreated,
            //               DateUpdated = d.DateUpdated,
            //               Title = d.Title,

            //           }).ToList();
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}     
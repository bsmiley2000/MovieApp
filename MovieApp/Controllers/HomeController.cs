using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext movieContext { get; set; }
        // Constructor
        public HomeController(MovieContext x)
        {
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts ()
        {
            return View("myPodcasts");
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(ar);
                movieContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();

                return View();
            }
         
        }
        [HttpGet]
        public IActionResult WaitList()
        {
            var applications = movieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = movieContext.Categories.ToList();

            var application = movieContext.Responses.FirstOrDefault(x => x.ApplicationId == applicationid);

            return View("MovieForm", application);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse ar)
        {
            movieContext.Update(ar);
            movieContext.SaveChanges();

            return RedirectToAction("WaitList");
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = movieContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movieContext.Responses.Remove(ar);
            movieContext.SaveChanges();

            return RedirectToAction("WaitList");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeansoftX_FeatureToggle.Models;
using LeansoftX_FeatureToggle.Models.FeatureToggles;

namespace LeansoftX_FeatureToggle.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmailNotifyFeature _emailNotifyFeature;

        public HomeController(EmailNotifyFeature emailNotifyFeature)
        {
            _emailNotifyFeature = emailNotifyFeature;
        }

        public IActionResult Index()
        {
            ViewBag.EmailNotifyFeature = _emailNotifyFeature;
            return View(new Models.HomeIndexViewModel());
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

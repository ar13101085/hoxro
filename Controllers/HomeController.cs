using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hoxro.Data;
using Microsoft.AspNetCore.Mvc;
using Hoxro.Models;
using Microsoft.EntityFrameworkCore;

namespace Hoxro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
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

        [HttpGet("GetMatterTypes")]
        public IActionResult GetMatterTypes()
        {
            var allMatter = _db.MatterType.Count();
            return Ok(allMatter);
           // var results = Db.Database.ExecuteSqlCommand("SELECT name FROM sys.tables ORDER BY name");
           // return Ok(results);
            
        }
    }
}

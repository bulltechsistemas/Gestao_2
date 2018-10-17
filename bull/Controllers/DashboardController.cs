using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bull.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bull.Controllers
{
    public class DashboardController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var lista = new List<DashboardModel>() {
                {
                    new DashboardModel(){
                    NomePagina = "DashBoard"
                    }
                }
            };

            return View(lista);
            // return View(await _context.AnimalModel.ToListAsync());
        }
    }
}

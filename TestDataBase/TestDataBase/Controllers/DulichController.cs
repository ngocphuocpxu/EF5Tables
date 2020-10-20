using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDataBase.Models;

namespace TestDataBase.Controllers
{
    public class DulichController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DulichController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var dulichs = _appDbContext.Duliches.Include(p => p.Category).ToList();

            return View(dulichs);
        }
    }
}

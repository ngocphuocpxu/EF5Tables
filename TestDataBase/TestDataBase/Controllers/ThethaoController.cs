using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDataBase.Models;

namespace TestDataBase.Controllers
{
    public class ThethaoController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ThethaoController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var thethaos = _appDbContext.Thethaos.Include(p => p.Category).ToList();

            return View(thethaos);
        }
    }
}

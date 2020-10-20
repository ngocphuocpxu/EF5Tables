using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDataBase.Models;

namespace TestDataBase.Controllers
{
    public class SuckhoeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SuckhoeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var suckhoes = _appDbContext.Suckhoes.Include(p => p.Category).ToList();

            return View(suckhoes);
        }
    }
}
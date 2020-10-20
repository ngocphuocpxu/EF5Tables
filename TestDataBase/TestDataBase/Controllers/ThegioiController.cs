using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDataBase.Models;

namespace TestDataBase.Controllers
{
    public class ThegioiController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ThegioiController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var thegiois = _appDbContext.Thegiois.Include(p => p.Category).ToList();
         
            return View(thegiois);
        }
    }
}

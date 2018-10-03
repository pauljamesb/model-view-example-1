using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S1.Data;
using S1.Models;

namespace S1.Controllers
{
    public class MenuController : Controller
    {

        private readonly ApplicationDbContext _db;
        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            MenuModelView myMod = new MenuModelView();
            myMod.IceCreamMV = _db.AllFlavours.ToList();
            myMod.PizzaMV = _db.AllPizzas.ToList();
            return View(myMod);
        }
    }
}
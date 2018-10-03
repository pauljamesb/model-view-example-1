using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S1.Data;
using S1.Models;

namespace S1.Controllers
{
    public class PizzaController : Controller
    {


        private readonly ApplicationDbContext _db;
        public PizzaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.AllPizzas.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        // POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pizza pizza)
        {
            if(ModelState.IsValid)
            {
                _db.Add(pizza);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }




    }
}
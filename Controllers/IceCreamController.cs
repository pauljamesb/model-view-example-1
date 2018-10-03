using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S1.Data;
using S1.Models;

namespace S1.Controllers
{
    public class IceCreamController : Controller
    {

        private readonly ApplicationDbContext _db;
        public IceCreamController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.AllFlavours.ToList());
        }



        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IceCream iceCream)
        {
            if(ModelState.IsValid)
            {
                _db.Add(iceCream);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }



    }
}
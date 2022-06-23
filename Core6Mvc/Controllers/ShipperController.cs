﻿using Microsoft.AspNetCore.Mvc;
using Nortwhind.Entities;

namespace Core6Mvc.Controllers
{
    public class ShipperController : Controller
    {
        private NorthwindContext context;

        public ShipperController(NorthwindContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Shippers.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {

            Shipper shipper = new Shipper();
            return View(shipper);
        }

        [HttpPost]
        public IActionResult Create(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                context.Shippers.Add(shipper);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(shipper);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var shipper = context.Shippers.Find(id);
            return View(shipper);
        }

        [HttpPost]
        public IActionResult Delete(Shipper shipper)
        {
            var removeShipper = context.Shippers.FirstOrDefault(p => p.ShipperId == shipper.ShipperId);
            context.Remove(removeShipper);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Shipper shipper = context.Shippers.Find(id);
            return View(shipper);

        }

        [HttpPost]
        public IActionResult Update(Shipper shipper)
        {
            context.Update(shipper);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
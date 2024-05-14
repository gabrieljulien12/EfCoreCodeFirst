using EfCoreCodeFirst.Models.Context;
using EfCoreCodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace EfCoreCodeFirst.Controllers
{
    public class CatogoryController : Controller
    {
        MyContext _db;
        public CatogoryController(MyContext context)
        {
            _db = context;
        }

        public IActionResult GetCatagories ()
        {
            return View(_db.catagories.ToList());
        }
        
        public IActionResult CreateCatogory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCatogory(Catagory item)
        {
            _db.catagories.Add(item);
            _db.SaveChanges();
            return RedirectToAction("GetCatagories");
        }

        public IActionResult UptadeCatagory(int id) 
        { 
            return View(_db.catagories.Find(id));
        }

        [HttpPost]
        public IActionResult UptadeCatagory(Catagory item)
        {
            Catagory original = _db.catagories.Find(item.ID);
            original.CatagoryName = item.CatagoryName;
            original.Description = item.Description;
            original.ModifiedDate = DateTime.Now;
            _db.SaveChanges();
            return RedirectToAction("GetCatagories");
        }

     
        public IActionResult DeleteCatagory(int ID)
        {
           _db.catagories.Remove(_db.catagories.Find(ID));
            _db.SaveChanges();
            return RedirectToAction("GetCatagories");
        }
    }
}

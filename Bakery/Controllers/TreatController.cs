using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Controllers
{
  public class TreatsController : Controller
  {
    private readonly BakeryContext _db;

    public TreatsController(BakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List <Treat> model = _db.Treats.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      if (!ModelState.IsValid)
      {
        return View(treat);
      }
     else
      {
         _db.Treats.Add(treat);
         _db.SaveChanges();
         return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Treat thisTreat = _db.Treats
                            // .Include(treat => treat.JoinEntities)
                            // .ThenInclude(join => join.Flavor)
                            .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
        Treat thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
        return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
     if (!ModelState.IsValid)
      {
        return View(treat);
      }
     else
       {
        _db.Treats.Update(treat);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
  }
}
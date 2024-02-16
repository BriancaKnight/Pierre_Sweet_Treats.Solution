using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Controllers
  {
    public class HomeController :  Controller
    {
      private readonly BakeryContext _db;
    
    public HomeController(BakeryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Home - Pierre's Bakery";
      return View();
    }
  }
}
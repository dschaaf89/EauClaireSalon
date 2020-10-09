using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using HairSalon.Models;
namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistController(HairSalonContext db)
    {
        _db = db;
    }
    public ActionResult Index()
    {
        List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
        _db.Stylists.Add(stylist);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
        Stylist thisStylist = _db.Stylists
        .Include(Stylist => Stylist.Clients)
        .FirstOrDefault(Stylist => Stylist.StylistId == id);
        return View(thisStylist);
    }
    public ActionResult Edit(int id)
    {
        Stylist thisStylist = _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == id);
        return View(thisStylist);
    }
     [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
     public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == id);
      return View(thisStylist);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(Stylist => Stylist.StylistId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }



  }
}
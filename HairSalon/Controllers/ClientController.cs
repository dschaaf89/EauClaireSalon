using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
namespace HairSalon.Controllers
{
    public class ClientController : Controller
    {
        private readonly HairSalonContext _db;
        public ClientController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
    {
        List<Client> model = _db.Clients.Include(Client => Client.Stylist).ToList();
        return View(model);
    }
        public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Client client)
    {
      
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
        Client thisClient = _db.Clients.FirstOrDefault(Clients => Clients.ClientId == id);
        ViewBag.StylistName = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == thisClient.StylistId);
    }
    }
    
}
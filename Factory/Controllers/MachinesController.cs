using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View (_db.Machines.ToList());
    }

    public ActionResult Details (int id)
    {
      var thisMachine = _db.Machines
        .Include(machine => machine.Engineers)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "FullName");
      return View();
    }

    [HttpPost]
    public ActionResult Create (Machine machine, int EngineerId)
    {
      _db.Machines.Add(machine);
      if (EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() {EngineerId = EngineerId, MachineId = machine.MachineId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddEngineer (int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(Machine =>machine.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "FullName");
      return View(thisMachine);
    }
  }
}
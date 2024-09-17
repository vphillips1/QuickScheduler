using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using QuickSchedulerApp.Data;
using QuickSchedulerApp.Models;

namespace QuickSchedulerApp.Controllers
{
    public class AppointmentEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public AppointmentEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<AppointmentEntry> objAppointmentEntryList = _db.AppointmentEntries.ToList();
            return View(objAppointmentEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AppointmentEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.AppointmentEntries.Add(obj); //Adds the new diary entry to the database
                _db.SaveChanges(); // Saves the changes to the database
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AppointmentEntry? appointmentEntry = _db.AppointmentEntries.Find(id);

            if (appointmentEntry == null)
            {
                return NotFound();
            }
            return View(appointmentEntry);
        }



        [HttpPost]
        public IActionResult Edit(AppointmentEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }
            if (ModelState.IsValid)
            {
                _db.AppointmentEntries.Update(obj); //update the diary entry in the database 
                _db.SaveChanges(); // Saves the changes to the database
                return RedirectToAction("Index");
            }

            return View(obj);

        }



        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AppointmentEntry? appointmentEntry = _db.AppointmentEntries.Find(id);

            if (appointmentEntry == null)
            {
                return NotFound();
            }
            return View(appointmentEntry);
        }


        [HttpPost]
        public IActionResult Delete(AppointmentEntry obj)
        {
            _db.AppointmentEntries.Remove(obj); //Remove the diary entry from the database 
            _db.SaveChanges(); // Saves the changes to the database
            return RedirectToAction("Index");

        }



    }
}

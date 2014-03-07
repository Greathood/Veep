using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veep.Models;
using System.Data.Entity

namespace Veep.Controllers
{
    public class NoteController : Controller
    {
        //
        // GET: /Note/

        public ActionResult Index()
        {
            var notes = db.Note;
            return View(notes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Note note)
        {
            db.Note.Add(note);
            db.SaveChanges();

            return RedirectToAction("Create");
        }
        
        public ActionResult Edit(int id)
        {
            var note = from s in db.Note
                       where s.ID == id
                       select s;

            return View(note.First());
        }
       

        [HttpPost]
        public ActionResult Edit(Note note)
        {
            db.Entry<Note>(note).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("index", new { id = note.ID});
        } 
        
        private NoteContext db = new NoteContext();
    }
}

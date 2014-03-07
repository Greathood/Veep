﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veep.Models;

namespace Veep.Controllers
{
    public class NoteController : Controller
    {
        //
        // GET: /Note/

        public ActionResult Index()
        {
            return View();
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

        private NoteContext db = new NoteContext();
    }
}
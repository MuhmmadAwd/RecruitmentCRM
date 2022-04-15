using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalDev.entitiy;
using System.Web.Mvc;
using Business;
using System.IO;
using System.Data;

namespace GlobalDev.Controllers
{
    public class StudentController : Controller
    {
        private readonly Business<Students> Business;
        public StudentController(Business<Students> business)
        {
            Business = business;
        }
        public ActionResult Index()
        {
            return View(Business.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students Students)
        {
            //upload img
            string fileName = Path.GetFileNameWithoutExtension(Students.ImageFile.FileName);
            string extension = Path.GetExtension(Students.ImageFile.FileName);
            fileName = fileName+ DateTime.Now.ToString("yymmssffff") + extension;   
            Students.Image = "../Photos/" + fileName;
            fileName = Path.Combine(Server.MapPath("../Photos/"),fileName);
            Students.ImageFile.SaveAs(fileName);
            // add it
            Business.Add(Students);
            Business.Save();
            return RedirectToAction("Index","Student");
        }

    }
}
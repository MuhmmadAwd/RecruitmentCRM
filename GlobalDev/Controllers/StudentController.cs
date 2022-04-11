using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalDev.entitiy;
using System.Web.Mvc;
using Repo;
using System.IO;
using System.Data;

namespace GlobalDev.Controllers
{
    public class StudentController : Controller
    {
        public IRepository<Students> Repo;
        public StudentController(IRepository<Students> repo)
        {
            Repo = repo;
        }
        public ActionResult Index()
        {
            return View(Repo.GetAll());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students Students)
        {
            string fileName = Path.GetFileNameWithoutExtension(Students.ImageFile.FileName);
            string extension = Path.GetExtension(Students.ImageFile.FileName);
            fileName = fileName+ DateTime.Now.ToString("yymmssffff") + extension;   
            Students.Image = "../Photos/" + fileName;
            fileName = Path.Combine(Server.MapPath("../Photos/"),fileName);
            Students.ImageFile.SaveAs(fileName);
            Repo.Add(Students);
            Repo.Save();
            return RedirectToAction("Index","Student");
        }

    }
}
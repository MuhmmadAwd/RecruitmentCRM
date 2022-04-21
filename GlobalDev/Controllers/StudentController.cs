using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalDev.Dal;
using System.Web.Mvc;
using GlobalDev.Bal;
using GlobalDev.Dto;
using System.IO;
using System.Data;

namespace GlobalDev.Controllers
{
    public class StudentController : Controller
    {
        private readonly Business Business;
        public StudentController(Business business)
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
        public ActionResult Create(StudentDto studentDto)
        {
            //upload img
            string fileName = Path.GetFileNameWithoutExtension(studentDto.ImageFile.FileName);
            string extension = Path.GetExtension(studentDto.ImageFile.FileName);
            fileName = fileName+ DateTime.Now.ToString("yymmssffff") + extension;
            studentDto.Image = "../Photos/" + fileName;
            fileName = Path.Combine(Server.MapPath("../Photos/"),fileName);
            studentDto.ImageFile.SaveAs(fileName);
            // add it
            Business.Add(studentDto);
            Business.Save();
            return RedirectToAction("Index","Student");
        }

    }
}
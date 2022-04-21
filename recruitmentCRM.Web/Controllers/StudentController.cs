using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using recruitmentCRM.Bal;
using recruitmentCRM.Dto;
using recruitmentCRM.Dal;

namespace recruitmentCRM.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService StudentService;
        public StudentController(StudentService studentService)
        {
            StudentService = studentService;
        }
        public ActionResult Index()
        {
            return View(StudentService.GetAll());
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
            fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
            studentDto.Image = "../Photos/" + fileName;
            fileName = Path.Combine(Server.MapPath("../Photos/"), fileName);
            studentDto.ImageFile.SaveAs(fileName);
            // add it
            StudentService.Add(studentDto);
            StudentService.Save();
            return RedirectToAction("Index", "Student");
        }
    }
}
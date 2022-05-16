using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using RecruitmentCRM.Bal;
using RecruitmentCRM.Dto;
using RecruitmentCRM.Dal;

namespace RecruitmentCRM.Web.Controllers
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
            foreach (var file in studentDto.DocumentFile)
            {
                if (studentDto.DocumentFile != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    studentDto.Document = "../Photos/" + fileName;
                    var path = Path.Combine(Server.MapPath("../Photos/"), fileName);
                    file.SaveAs(path);
                }
            }


            // add it
            StudentService.Add(studentDto);
            StudentService.Save();
            return RedirectToAction("Index", "Student");
        }
    }
}
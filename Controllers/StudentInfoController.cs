using Asp.NetCore_MVC_Practice.EntityDbData;
using Asp.NetCore_MVC_Practice.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using System.Runtime.CompilerServices;
using Asp.NetCore_MVC_Practice.Models;


namespace Asp.NetCore_MVC_Practice.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentInfoController(ApplicationDbContext db)
        {
            _db = db;
        }

        //display data from table in html
        public IActionResult Index()
        {
            List<Models.DbTable> studentInfoList = _db.StudentInfo.ToList();
            return View(studentInfoList);
        }



        public IActionResult AddRecord()
        {
            return View();
        }


        //add record to the database
        [HttpPost]
        public IActionResult AddRecord(Models.DbTable obj)
        {

            if(obj.Name == null)
               obj.Name = string.Empty;
            else
            {
                if (!obj.Name.Equals(obj.Name.ToUpper()))
                {
                    ModelState.AddModelError("Name", "Name must be capitalized");
                } 
                else if (int.TryParse(obj.Name, out int number))
                {
                    if (obj.Name == number.ToString())
                    {
                        ModelState.AddModelError("Name", "number must not allowed");
                    }
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        _db.StudentInfo.Add(obj);
                        _db.SaveChanges();
                        return RedirectToAction("index");
                    }
                }    
            }

            return View();
        }





        //para ma view yung Edit form kapag pinindot sa table yung edit
        public IActionResult Edit(int id)
        {
            var GetEdit =  _db.StudentInfo.Find(id);
           
            return View(GetEdit);
        }



        //Edit Record to the database
        [HttpPost]
        public IActionResult Edit(Models.DbTable studentData)
        {

            var edit = _db.StudentInfo.Find(studentData.Id);


                if (edit != null)
                {
                    edit.Name = studentData.Name;
                    edit.Lastname = studentData.Lastname;
                    edit.age = studentData.age;

                    _db.SaveChanges();
                }



            return RedirectToAction("index");

        }

        



    }
}

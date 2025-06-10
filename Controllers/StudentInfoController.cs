using Asp.NetCore_MVC_Practice.EntityDbData;
using Asp.NetCore_MVC_Practice.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using System.Runtime.CompilerServices;
using Asp.NetCore_MVC_Practice.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


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
        public IActionResult add(Models.DbTable obj)
        {
            if (ModelState.IsValid)
            {
                _db.StudentInfo.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }


        //para ma view yung Edit form kapag pinindot sa table yung edit
        public IActionResult Edit(int id)
        {
            var GetEdit = _db.StudentInfo.Find(id);
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



        [HttpPost]
        public IActionResult Delete(int id)
        {
            var record =  _db.StudentInfo.Find(id);
            if(record == null)
            {
                return NotFound();
            }
            _db.StudentInfo.Remove(record);
            _db.SaveChanges();

            return RedirectToAction("index");
        }


        [HttpPost]
        public async Task<IActionResult> Search(string Searchstring)
        {
            if (_db.StudentInfo == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }
            var names = from m in _db.StudentInfo select m;

            if (!String.IsNullOrEmpty(Searchstring))
            {
                names = names.Where(s => s.Name!.ToUpper().Contains(Searchstring.ToUpper()));
            }

            return View("index",await names.ToListAsync());

        }



    }
}

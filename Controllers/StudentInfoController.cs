using Asp.NetCore_MVC_Practice.EntityDbData;
using Asp.NetCore_MVC_Practice.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore_MVC_Practice.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentInfoController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Models.DbTable> studentInfoList = _db.StudentInfo.ToList();
            return View(studentInfoList);
        }


        public IActionResult AddRecord()
        {
            return View();
        }


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

        



    }
}

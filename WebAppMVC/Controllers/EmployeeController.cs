using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployeeRepository _emprep;
        public EmployeeController(IEmployeeRepository repo)
        {
            _emprep = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var lemp=_emprep.GetAllEmployee();
            return View(lemp);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var emp = _emprep.GetEmployee(Id);
            return View(emp);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Employee emp)
        {
            if(ModelState.IsValid) 
            {
                _emprep.AddEmp(emp);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View(_emprep.GetEmployee(Id));
        }

        [HttpPost]
        public IActionResult Edit(int Id, Employee emp)
        {
            if(ModelState.IsValid)
            {
                _emprep.UpdateEmployee(emp);
                return RedirectToAction(nameof(Index)); 
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            return View(_emprep.GetEmployee(Id));
        }
        [HttpPost]
        public ActionResult Delete(int id,Employee emp)
        {
            _emprep.DeleteEmployee(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

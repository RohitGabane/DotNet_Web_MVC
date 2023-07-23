using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public readonly IDepartmentRepository _deprep;
        public DepartmentController(IDepartmentRepository repo)
        {
            _deprep = repo;
        }
        public IActionResult Index()
        {
            var lemp = _deprep.GetAllDepartment();

            return View(lemp);
        }
        public IActionResult Details(int Id)
        {
            var dep = _deprep.GetDepartment(Id);
            return View(dep);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Department dep)
        {
            if (ModelState.IsValid)
            {
                _deprep.AddDep(dep);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}

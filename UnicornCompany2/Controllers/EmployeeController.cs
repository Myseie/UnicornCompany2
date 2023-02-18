using Microsoft.AspNetCore.Mvc;
using Database;

namespace UnicornCompany2.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task <IActionResult> Index()
        {
            Database.Database db = new Database.Database();
            List <Employee> employees = await db.GetAllEmployees();
            return View(employees);
        }


        
    }
}

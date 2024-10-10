using DoctorsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsApp.Controllers
{
    public class PatientsController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var patients = dbContext.Patients.Include(e=> e.Doctor);
            return View(model: patients);
        }
    }
}

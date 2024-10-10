using DoctorsApp.Data;
using DoctorsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DoctorsApp.Controllers
{
    public class BookAppointmentController : Controller
    {
        ApplicationDbContext dbcontext = new ApplicationDbContext(); 
        public IActionResult Index()
        {
            var doctors = dbcontext.Doctors.ToList();

            return View(model : doctors);
        }
        public IActionResult completeAppointment(int id)
        {
           var doctor = dbcontext.Doctors.Find(id);
            if (doctor != null)
            {
                return View(model: doctor );

            }
            else
            {
                return View (nameof(Index));
            }

        }
        public IActionResult CompleteBook(string name, DateTime date, TimeSpan time , int id )
        {
            Doctor doctor = dbcontext.Doctors.Find(id);
            Patient patient = new Patient { Name = name , date = date , time = time , Doctor= doctor , DoctorId= id };
            dbcontext.Patients.Add(patient);
            doctor.Patients.Add(patient);
            dbcontext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

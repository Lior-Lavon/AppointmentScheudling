using AppointmentScheudling.Services;
using AppointmentScheudling.Utility;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheudling.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            ViewBag.DoctorList = _appointmentService.GetDoctrorList();
//            ViewBag.PatientList = _appointmentService.GetPatientList();
//            ViewBag.Duration = Helper.GetTimeDropDown();

            return View();
        }
    }
}

using AppointmentScheudling.Models.ViewModels;
using System.Collections.Generic;

namespace AppointmentScheudling.Services
{
    public interface IAppointmentService
    {
        // get all doctors
        public List<DoctorVM> GetDoctrorList();
        // get all patients
        public List<PatientVM> GetPatientList();
    }
}

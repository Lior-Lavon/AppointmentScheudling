using AppointmentScheudling.Models;
using AppointmentScheudling.Models.ViewModels;
using AppointmentScheudling.Utility;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AppointmentScheudling.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly DatabaseContext _dbContext;

        public AppointmentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<DoctorVM> GetDoctrorList()
        {
            var doctors = (from user in _dbContext.Users
                           join userRoles in _dbContext.UserRoles on user.Id equals userRoles.UserId 
                           join roles in _dbContext.Roles on userRoles.RoleId equals roles.Id
                           where roles.Name.Equals(Helper.Doctor)
                           select new DoctorVM
                           {
                               Id = user.Id,
                               Name = user.Name,
                           }).ToList();


            return doctors;
        }

        public List<PatientVM> GetPatientList()
        {
            var patients = (from user in _dbContext.Users
                            join userRole in _dbContext.UserRoles on user.Id equals userRole.UserId
                            join role in _dbContext.Roles on userRole.RoleId equals role.Id
                            where role.Name.Equals(Helper.Patient)
                            select new PatientVM
                            {
                                Id=user.Id,
                                Name=user.Name
                            }).ToList();
            return patients;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AppointmentScheudling.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem> {
                new SelectListItem { Value = Admin, Text = Admin},
                new SelectListItem { Value = Patient, Text = Patient},
                new SelectListItem { Value = Doctor, Text = Doctor}
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;

            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 1; i <= 12; i++)
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr" });
                minute += 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + " Hr" });
                minute += 30;
            }

            return duration;
        }

    }
}

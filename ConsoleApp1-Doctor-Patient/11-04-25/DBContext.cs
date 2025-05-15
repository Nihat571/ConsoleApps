using _11_04_25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_25
{
    public static class DBContext
    {
        public static Doctor[] doctors = new Doctor[0];
        public static Patient[] patients = new Patient[0];
        public static Appointment[] appointments = new Appointment[0]; 
           public static void AddNewPatient(Patient patient)
            {
            Array.Resize(ref patients,patients.Length+1);
            patients[^1] = patient;
            }

        public static void AddNewDoctor(Doctor doctor) 
        {
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[^1] = doctor;
        }

        public static void AddNewAppointment(Appointment appointment) 
        {
            Array.Resize(ref appointments, appointments.Length + 1);
            appointments[^1] = appointment;
        }



    }
}

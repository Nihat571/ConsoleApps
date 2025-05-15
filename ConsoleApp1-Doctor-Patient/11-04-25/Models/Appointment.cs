using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_25.Models;

public class Appointment
{
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string DateTime { get; set; }
}

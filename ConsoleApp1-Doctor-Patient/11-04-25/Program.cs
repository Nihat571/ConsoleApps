
using _11_04_25.Interfaces;
using _11_04_25.Models;

namespace _11_04_25;

public class Program
{
    static void Main(string[] args)
    {

        do {
        start:
            
            Console.WriteLine("1. Yeni xəstə əlavə et\r\n" +
                "2. Yeni həkim əlavə et\r\n" +
                "3. Həkimə xəstə təyin et\r\n" +
                "4. Xəstələrin siyahısı\r\n" +
                "5. Həkimlərin siyahısı\r\n" +
                "6. Statistikaya bax\r\n" +
                "7. Çıxış\r\n" +
                "8. Konsolu temizle\r\n");
            
            Console.WriteLine("Seciminizi edin:");
            
           string userNumber = Console.ReadLine();
            int number;
            if (!int.TryParse(userNumber, out number)) 
            {
            goto start;
            }
            switch (userNumber)
            {
                case "1":
                    Console.WriteLine("add Patient's name");
                    string newPatientName = Console.ReadLine();

                    Console.WriteLine("add Patient's surname");
                    string newPatientSurName = Console.ReadLine();

                    Console.WriteLine("add Patient's gender");
                    string newPatientGender = Console.ReadLine();

                    Console.WriteLine("add Patient's age:");
                    byte newPatientAge = byte.Parse(Console.ReadLine());

                    try
                    {
                        Patient patient = new Patient(newPatientName, newPatientSurName, newPatientGender, newPatientAge);
                        DBContext.AddNewPatient(patient);
                        Console.WriteLine("added new Patient");
                    }
                    catch (MyException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case "2":
                    Console.WriteLine("add Doctor's name");
                    string newDoctorName = Console.ReadLine();

                    Console.WriteLine("add Doctor's surname");
                    string newDoctorSurName = Console.ReadLine();

                    Console.WriteLine("add Doctor's gender(K/Q)");
                    string newDoctorGender = Console.ReadLine();

                    Console.WriteLine("add Doctor's age:");
                    int newDoctorAge = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("add Doctor's experience year:");
                    int newDoctorExperienceYear = int.Parse(Console.ReadLine());
                    try
                    {
                        Doctor doctor = new Doctor(newDoctorName, newDoctorSurName, newDoctorGender, newDoctorExperienceYear);
                        DBContext.AddNewDoctor(doctor);
                        Console.WriteLine("added new doctor");
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine(e.Message);
                        goto start;
                    }
                        break;
                case "3":
                    foreach (Doctor item in DBContext.doctors)
                    {
                        Console.WriteLine($"{item.Id}.{item.Name} {item.SurName} Tecrubesi:{item.ExperienceYear} il");
                    }
                    Console.WriteLine("Secmek istediyiniz hekimin sira nomresini daxil edin:");
                    int selectedoctorId = int.Parse(Console.ReadLine());
                    foreach (Doctor item in DBContext.doctors)
                    {
                        if (item.Id == selectedoctorId)
                        {
                            Console.WriteLine($"Sizin hekiminiz {item.Name} {item.SurName}-dir.Zehmet olmasa otagina yaxinlasin!");
                        }    
                    }
                    
                    break;
                case "7":
                    Console.Clear();
                    break;
                case "5":

                    foreach (Doctor item in DBContext.doctors)
                    {
                        if (item == null)
                        {
                            Console.WriteLine("Hekim daxil edilmeyib");
                        }
                        else
                        {
                            item.DisplayInfo();
                        }
                    }

                    break;
                case "4":

                    foreach (Patient item in DBContext.patients)
                    {
                        item.DisplayInfo();
                    }
                     break;
                case "8":
                    Console.Clear();
                    break;
                case "6":
                    Console.WriteLine("Bu hisse heleki yoxdur.");
                    break;
                 default:
                            break;
                        }
        }
        
        while (true);
    }
}

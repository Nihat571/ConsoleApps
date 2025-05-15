using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11_04_25.Interfaces;

namespace _11_04_25.Models;

public class Doctor:PersonBase,IPerson
{
    public Doctor(string name,string surname,string gender,int experinceYear):base(name,surname,gender)
    {
        exprienceYear = experinceYear;
    }
    private int exprienceYear;
    public int ExperienceYear { 
        get
        {
        return exprienceYear;
        }
        set
        {
            if (value <= 0)
            {
                throw new MyException("Dogru tecrube ili daxil edilmedi");
           }
            else
            {
                exprienceYear = value;
            }
        }
    }

    public void IDisplayable()
    {
        Console.WriteLine($"{Name} {SurName} ");
    }


   public void DisplayInfo()
    {
        
            Console.WriteLine("Xestelerin siyahisi:");
            Console.WriteLine($"{Id}. {Name} {SurName} ");
        
    }


    public string GetFullName()
    {
        return $"{Name} {SurName}";
    }

}

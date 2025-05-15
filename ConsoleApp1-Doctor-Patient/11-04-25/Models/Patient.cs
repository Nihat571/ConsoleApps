using _11_04_25.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_25.Models;

public class Patient: PersonBase,IPerson
{
    private byte age;
	public byte Age {
        get {
            return age;
        }
        set
        {
            if (value<0)
            {
                throw new MyException("Yasinizi dogru daxil edin");
            }
            else
            {
                age = value;
            }
        }

            }
	public Patient(string name,string surname,string gender,byte age):base(name,surname,gender)
	{
		Age = age;
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

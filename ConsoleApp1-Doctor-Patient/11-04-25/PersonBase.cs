using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_04_25;

public abstract class PersonBase
{
    private static int _id;
    private string name;
    private string surname;
    private string gender;

    public int Id;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (value.Length <= 2)
            {
                Console.WriteLine("Adinizi tam daxil edin!");
            }
            else
            {
                name = value;
            }
        }

    }
    public string SurName
    {
        get
        {
            return surname;
        }

        set
        {
            
            if (value.Length <= 5)
            {
                throw new Exception("Soyadinizi dogru daxil edin");
            }
            else
            {
                surname = value;
            }
        }

    }
   
    public string Gender
    {
        get
        {
            return gender;
        }
        set
        {

            if (value == "K" || value == "k" || value == "Q" || value == "q")
            {
                gender = value;
            }
            else
            {
                throw new Exception("Cinsinizi dogru daxil edin(k/q)");
            }

        }
    }
    public PersonBase(string name,string surname,string gender)
    {
        Id = ++_id;
        Name =name;
        SurName=surname;
        Gender = gender;
    }
}

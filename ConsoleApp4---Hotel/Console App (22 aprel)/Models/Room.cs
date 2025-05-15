using Console_App__22_aprel_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App__22_aprel_.Models;

public class Room
{
    private int _id;
    public int Id { get; set; }
    public string RoomName;

    private double price;
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value > 50)
            {
                value = price;
            }
            else
            {
                throw new NotAvailableException("Bu qiymete otaq elave etmek mumkun deyil");
            }
        }
    }
    private int personCapacity;
    public int PersonCapacity
    {
        get
        {
            return personCapacity;
        }
        set
        {
            if (value < 1 || value>7)
            {
                throw new NotAvailableException("Bu saya uygun otaq yoxdur.");
            }
            else
            {
                personCapacity = value;
            }
        }
    }
    public bool IsAvialable = true;
    public Room(string name,double price,int personCapacity)
    {
        RoomName = name; 
        Price = price;
        PersonCapacity = personCapacity;
    }
}

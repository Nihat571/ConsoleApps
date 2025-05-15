using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App__22_aprel_.Models;

public class Hotel
{
    private int _id;
    public int Id { get; set; }
    public string HotelName;
   
    public Hotel(string name)
    {
        HotelName = name;
    }
}

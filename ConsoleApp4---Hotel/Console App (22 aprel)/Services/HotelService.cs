using Console_App__22_aprel_.Exceptions;
using Console_App__22_aprel_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App__22_aprel_.Services;

public class HotelService
{
    public int counter = 1;
    #region CREATE
    List<Hotel> hotels = new List<Hotel>();
    public void AddHotel(Hotel hotel)
    {
        //hotel.Id = counter++;
        //hotels.Add(hotel);
        //Console.WriteLine("added hotel");
        if (hotels.Count !=0)
        {
            foreach (var item in hotels)
            {
                if (item.HotelName ==hotel.HotelName)
                {
                   throw new NotAvailableException("Artiq bu adla hotel movcuddur.");
                }
                else
                {
                    hotel.Id = counter++;
                    hotels.Add(hotel);
                    Console.WriteLine("added hotel");
                }
            }
        }
        else
        {
            hotel.Id = counter++;
            hotels.Add(hotel);
            Console.WriteLine("added hotel");
        }
    }

    #endregion
    #region READ
    public void ShowAllHotel()
    {
        if (hotels.Count !=0)
        {
            foreach (var item in hotels)
            {
                Console.WriteLine($"No: {item.Id} name: {item.HotelName}");
            }
        }
        else
        {
            throw new NotAvailableException("Hec bir otel elave olunmayib.");
        }
  
    }
    #endregion
}
